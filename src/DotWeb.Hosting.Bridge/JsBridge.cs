﻿// Copyright 2009, Frank Laub
//
// This file is part of DotWeb.
//
// DotWeb is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// DotWeb is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with DotWeb.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using DotWeb.Utility;
using DotWeb.Hosting.Weaver;

namespace DotWeb.Hosting.Bridge
{
	using FunctionCacheMap = Dictionary<MethodBase, JsFunction>;
	using DelegateWrapperMap = Dictionary<Delegate, JsDelegateWrapper>;
	
	using ObjectToReferenceMap = Dictionary<object, int>;
	using ReferenceToObjectMap = Dictionary<int, object>;

	using JsObjectToReferenceMap = Dictionary<object, int>;

	public class JsBridge : IDotWebHost
	{
		private readonly ISession session;
		private readonly IObjectFactory factory;
		private readonly FunctionCacheMap functionCache = new FunctionCacheMap();
		private readonly DelegateWrapperMap remoteDelegates = new DelegateWrapperMap();
	
		private readonly ObjectToReferenceMap objToRef = new ObjectToReferenceMap();
		private readonly ReferenceToObjectMap refToObj = new ReferenceToObjectMap();

		private readonly JsObjectToReferenceMap jsObjectToRef = new JsObjectToReferenceMap();
		private readonly Dictionary<object, JsDynamicWrapper> dynamicWrappers = new Dictionary<object, JsDynamicWrapper>();

		private int lastRefId = 1;

		private bool isUnwrapping = false;

		public JsBridge(ISession session, IObjectFactory factory) {
			this.session = session;
			this.factory = factory;
		}

		public R GetObjectByRef<R>(int id) {
			return (R)this.refToObj[id];
		}

		private JsValue DispatchAndReturn() {
			ReturnMessage retMsg;
			while (true) {
				Dispatch(true, out retMsg);
				if (retMsg != null)
					break;
			}

			JsValue ret = retMsg.Value;
			if (retMsg.IsException) {
				if (ret.IsJsObject) {
//					var jne = new JsNativeException();
//					AddRemoteReference(jne, ret.RefId);
					throw new Exception("JsException");
				}

				if (retMsg.Value.IsObject) {
					object obj = this.refToObj[ret.RefId];
					throw (Exception)obj;
				}
				throw new Exception(ret.Object.ToString());
			}
			return ret;
		}

		public void DispatchForever() {
			while (true) {
				ReturnMessage msg;
				var ret = Dispatch(false, out msg);
				if (!ret)
					return;
			}
		}

		/// <summary>
		/// Read a message from the session and dispatch based on the MessageType.
		/// </summary>
		/// <param name="needsReturn">The caller is expecting a ReturnMessage.</param>
		/// <param name="retMsg">The ReturnMessage if received.</param>
		/// <returns>true when needsReturn is true and a QuitMessage is received, otherwise false.</returns>
		private bool Dispatch(bool needsReturn, out ReturnMessage retMsg) {
			IMessage msg = this.session.ReceiveMessage();
			switch (msg.MessageType) {
				case MessageType.Load:
					OnLoad((LoadMessage)msg);
					break;
				case MessageType.GetTypeRequest:
					GetTypeInfo((GetTypeRequestMessage)msg);
					break;
				case MessageType.InvokeDelegate:
					InvokeDelegate((InvokeDelegateMessage)msg);
					break;
				case MessageType.InvokeMember:
					InvokeMember((InvokeMemberMessage)msg);
					break;
				case MessageType.Return:
					if (needsReturn) {
						retMsg = (ReturnMessage)msg;
						return true;
					}
					throw new InvalidOperationException();
				case MessageType.Quit:
					if (needsReturn) {
						throw new Exception("Quit");
					}
					retMsg = null;
					return false;
				default:
					throw new InvalidOperationException();
			}
			retMsg = null;
			return true;
		}

		private void Reset() {
			this.remoteDelegates.Clear();
			this.functionCache.Clear();
			this.objToRef.Clear();
			this.refToObj.Clear();
			this.jsObjectToRef.Clear();
			this.isUnwrapping = false;
		}

		private Type PrepareType(string typeSpec) {
			var parts = typeSpec.Split(',');
			var typeName = parts[0].Trim();
			var asmName = parts[1].Trim();
			var binPath = parts[2].Trim();

			var asmPath = Path.Combine(binPath, asmName);
			if (!asmPath.EndsWith(".dll")) {
				asmPath += ".dll";
			}

			Assembly asm;
			if (asmName.StartsWith("Hosted-")) {
				// for testing
				asm = Assembly.LoadFrom(asmPath);
			}
			else {
				var weaver = new SimpleWeaver(binPath, binPath, new string[] { binPath }, false);
				asm = weaver.ProcessAssembly(asmPath);
			}
			return asm.GetType(typeName);
		}

		private void OnLoad(LoadMessage msg) {
			try {
				Reset();

				CreateInstance(PrepareType(msg.TypeName));

				var value = new JsValue(JsValueType.Void, null);
				var retMsg = new ReturnMessage { Value = value };
				this.session.SendMessage(retMsg);
			}
			catch (TargetInvocationException ex) {
				HandleException(ex.InnerException);
			}
			catch (Exception ex) {
				HandleException(ex);
			}
		}

		private object CreateInstance(Type type) {
			return this.factory.CreateInstance(this, type);
		}

		private void HandleException(Exception ex) {
			Debug.WriteLine(ex);
			var value = new JsValue(ex.Message);
			var retMsg = new ReturnMessage { Value = value, IsException = true };
			this.session.SendMessage(retMsg);
		}

		private void GetTypeInfo(GetTypeRequestMessage msg) {
			GetTypeResponseMessage retMsg;
			object obj = this.refToObj[msg.TargetId];
			if (obj is Delegate) {
				retMsg = new GetTypeResponseMessage {
					Members = new List<TypeMemberInfo>()
				};
			}
			else {
				var target = (IJsWrapper)obj;
				retMsg = target.GetTypeInfo();
			}
			this.session.SendMessage(retMsg);
		}

		private void InvokeMember(InvokeMemberMessage msg) {
			var target = (IJsWrapper)this.refToObj[msg.TargetId];
			try {
				Type retType;
				object ret = target.Invoke(msg.DispatchId, msg.DispatchType, msg.Parameters, out retType);
				bool isVoid = retType == typeof(void);
				var retMsg = new ReturnMessage { Value = WrapValue(ret, isVoid) };
				this.session.SendMessage(retMsg);
			}
			catch (Exception ex) {
				Debug.WriteLine(ex);
				var value = new JsValue(ex.Message);
				var retMsg = new ReturnMessage { Value = value, IsException = true };
				this.session.SendMessage(retMsg);
			}
		}

		private void InvokeDelegate(InvokeDelegateMessage msg) {
			var target = (Delegate)this.refToObj[msg.TargetId];
			var targetType = target.GetType();
			Debug.WriteLine(string.Format("InvokeDelegate: {0}", target));
			var args = UnwrapParameters(msg.Parameters, DispatchType.Method, target.Method);
			try {
				object ret = target.DynamicInvoke(args);
				var retType = target.Method.ReturnType;
				bool isVoid = retType == typeof(void);
				var retMsg = new ReturnMessage { Value = WrapValue(ret, isVoid) };
				this.session.SendMessage(retMsg);
			}
			catch (Exception ex) {
				Debug.WriteLine(ex);
				var value = new JsValue(ex.Message);
				var retMsg = new ReturnMessage { Value = value, IsException = true };
				this.session.SendMessage(retMsg);
			}
		}

		private bool GetLocalReference(object value, out int id) {
			if (!this.objToRef.TryGetValue(value, out id)) {
				id = lastRefId++;
				this.objToRef.Add(value, id);
				return false;
			}
			return true;
		}

		private int GetRemoteReference(object remote) {
			int id = 0;
			this.jsObjectToRef.TryGetValue(remote, out id);
			return id;
		}

		private void AddRemoteReference(object remote, int handle) {
			if (!this.jsObjectToRef.ContainsKey(remote)) {
				this.jsObjectToRef.Add(remote, handle);
			}
		}

		private JsValue[] WrapParameters(object[] args) {
			if (args == null) {
				return new JsValue[0];
			}
			return args.Select(x => WrapValue(x, false)).ToArray();
		}

		internal object[] UnwrapParameters(JsValue[] args, DispatchType dispType, MemberInfo member) {
			var fi = member as FieldInfo;
			if (fi != null) {
				throw new NotSupportedException("Fields are not supported JsObject members");
			}

			MethodBase method;
			if (dispType.IsMethod()) {
				method = member as MethodBase;
			}
			else if (dispType.IsPropertyGet()) {
				var pi = member as PropertyInfo;
				if (pi == null) {
					throw new InvalidOperationException();
				}
				method = pi.GetGetMethod();
			}
			else if (dispType.IsPropertyPut()) {
				var pi = member as PropertyInfo;
				if (pi == null) {
					throw new InvalidOperationException();
				}
				method = pi.GetSetMethod();
			}
			else
				throw new InvalidOperationException();

			var argTypes = method.GetParameters().Select(x => x.ParameterType);
			var ret = argTypes.Select((x, i) => UnwrapValue(args[i], x)).ToArray(); 
			return ret;
		}

		private static bool IsJsObject(Type type) {
			return type.IsDefinedInHierarchy<JsObjectAttribute>();
		}

		private static bool IsJsDynamic(Type type) {
			return type.IsDefinedInHierarchy<JsDynamicAttribute>();
		}

		private JsValue WrapValue(object arg, bool isVoid) {
			if (isVoid)
				return new JsValue(JsValueType.Void, null);

			if (IsJsObject(arg.GetType())) {
				int handle = GetRemoteReference(arg);
				Debug.Assert(handle != 0);
				return new JsValue(JsValueType.JsObject, handle);
			}

			JsValue ret = JsValue.FromPrimitive(arg);
			if (ret != null)
				return ret;

			if (arg is Delegate) {
				JsDelegateWrapper wrapper;
				if (this.remoteDelegates.TryGetValue((Delegate)arg, out wrapper)) {
					return new JsValue(JsValueType.JsObject, wrapper.Handle);
				}

				int id;
				if (!GetLocalReference(arg, out id)) {
					Debug.WriteLine(string.Format("Adding refToObj: delegate[{0}] -> {1}", arg, id));
					this.refToObj.Add(id, arg);
				}
				return new JsValue(JsValueType.Delegate, id);
			}
			if (arg is Array) {
				int id;
				if (!GetLocalReference(arg, out id)) {
					var wrapper = new JsArrayWrapper(this, arg as Array);
					Debug.WriteLine(string.Format("Adding refToObj: JsArrayWrapper[{0}] -> {1}", arg, id));
					this.refToObj.Add(id, wrapper);
				}
				return new JsValue(JsValueType.Object, id);
			}
			return GetObjectWrapper(arg);
		}

		private JsDynamicWrapper GetDynamicWrapper(object target) {
			JsDynamicWrapper ret;
			if (!this.dynamicWrappers.TryGetValue(target, out ret)) {
				ret = new JsDynamicWrapper(this, target);
				this.dynamicWrappers.Add(target, ret);
			}
			return ret;
		}

		private JsValue GetObjectWrapper(object arg) {
			int id;
			if (!GetLocalReference(arg, out id)) {
				IJsWrapper wrapper;
				if (IsJsDynamic(arg.GetType())) {
					wrapper = GetDynamicWrapper(arg);
				}
				else {
					wrapper = new JsObjectWrapper(this, arg);
				}
				Debug.WriteLine(string.Format("Adding refToObj: {0}[{1}] -> {2}", wrapper, arg, id));
				this.refToObj.Add(id, wrapper);
			}
			return new JsValue(JsValueType.Object, id);
		}

		internal object UnwrapValue(JsValue value, Type targetType) {
			if (value.IsJsObject) {
				if (typeof(Delegate).IsAssignableFrom(targetType)) {
					var wrapper = new JsDelegateWrapper(this, value.RefId, targetType);
					Delegate del = wrapper.GetDelegate();
					this.remoteDelegates.Add(del, wrapper);
					return del;
				}

				isUnwrapping = true;
				object ret;
				try {
					ret = CreateInstance(targetType);
				}
				finally {
					isUnwrapping = false;
				}

				AddRemoteReference(ret, value.RefId);

				return ret;
			}
			if (value.IsObject || value.IsDelegate) {
				return this.refToObj[value.RefId];
			}

			return value.Object;
		}

		internal object InvokeRemoteDelegate(Type retType, int handle, params object[] args) {
			JsValue[] wrapped = WrapParameters(args);
			var msg = new InvokeDelegateMessage {
				TargetId = handle,
				Parameters = wrapped
			};
			this.session.SendMessage(msg);
			JsValue value = DispatchAndReturn();
			return UnwrapValue(value, retType);
		}

		private JsFunction PrepareRemoteFunction(MethodBase method) {
			JsFunction function;
			if (!this.functionCache.TryGetValue(method, out function)) {
				function = new JsFunction(method);
				var msgDef = new DefineFunctionMessage {
					Name = function.Name,
					Parameters = function.Parameters,
					Body = function.Body
				};
				this.session.SendMessage(msgDef);
				this.functionCache.Add(method, function);
			}
			return function;
		}

		private bool IsObjectExtensions(Type type) {
			return type.FullName == "System.ObjectExtensions";
		}

		private object InvokeOnObjectExtensions(object scope, MethodInfo method, object[] args) {
			var obj = args.First();
			if (method.Name == "GetTypeName") {
				var type = obj.GetType();
				return type.FullName;
			}

			throw new NotSupportedException();
		}

		public object Invoke(object scope, object objMethod, object[] args) {
			try {
				MethodBase method = (MethodBase)objMethod;
				if (IsObjectExtensions(method.DeclaringType)) {
					return InvokeOnObjectExtensions(scope, (MethodInfo)method, args);
				}

				if (IsJsDynamic(method.DeclaringType)) {
					return InvokeOnDynamic(scope, (MethodInfo)method, args);
				}

				if (this.isUnwrapping)
					return null;

				JsFunction function = PrepareRemoteFunction(method);

				int hScope = 0;
				if (scope != null)
					hScope = GetRemoteReference(scope);

				JsValue[] wrapped;
				if (method.GetParameters().Count() == 1 && args.Length > 1) {
					wrapped = new JsValue[] { WrapValue(args, false) };
				}
				else {
					wrapped = WrapParameters(args);
				}

				var msg = new InvokeFunctionMessage {
					Name = function.Name,
					ScopeId = hScope,
					Parameters = wrapped
				};

				this.session.SendMessage(msg);
				JsValue value = DispatchAndReturn();
				if (value.IsNull || value.IsVoid) {
					return null;
				}

				if (method.IsConstructor) {
					Debug.Assert(value.IsJsObject);
					AddRemoteReference(scope, value.RefId);
					return null;
				}

				var mi = (MethodInfo)method;
				return UnwrapValue(value, mi.ReturnType);
			}
			catch (Exception ex) {
				Debug.WriteLine(ex);
				throw;
			}
		}

		object InvokeOnDynamic(object obj, MethodInfo method, object[] args) {
			var wrapper = GetDynamicWrapper(obj);			

			if (method.Name.StartsWith("set_")) {
				var name = method.Name.Substring("set_".Length);
				if (name == "Item") {
					wrapper.SetPropertyValue((string)args[0], args[1]);
				}
				else {
					wrapper.SetPropertyValue(name, args[0]);
				}
				return null;
			}
			else if (method.Name.StartsWith("get_")) {
				var name = method.Name.Substring("get_".Length);
				if (name == "Item") {
					return wrapper.GetPropertyValue((string)args[0]);
				}
				else {
					return wrapper.GetPropertyValue(name);
				}
			}

			throw new InvalidOperationException();
		}

		public T Cast<T>(object obj) {
			int handle = GetRemoteReference(obj);
			var brother = CreateInstance(typeof(T));
			AddRemoteReference(brother, handle);
			return (T)brother;
		}
	}

}
