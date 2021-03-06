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
using System.Collections;

namespace DotWeb.Hosting.Bridge
{
	class JsDynamicWrapper : JsWrapperBase, IJsWrapper
	{
		private readonly object target;
		private readonly Type targetType;
		private readonly Dictionary<string, object> properties = new Dictionary<string, object>();

		public JsDynamicWrapper(JsBridge bridge, object target) 
			: base(bridge) {
			this.target = target;
			var handle = Type.GetTypeHandle(this.target);
			this.targetType = Type.GetTypeFromHandle(handle);
		}

		[JsObject]
		class JsNativeHolder
		{
		}

		public object Invoke(DispatchIdentifier id, DispatchType dispType, JsValue[] jsArgs, out Type returnType) {
			if (dispType.IsMethod()) {
				return InvokeMethod(dispType, id, jsArgs, out returnType);
			}

			if (dispType.IsPropertyPut()) {
				return SetProperty(id, jsArgs, out returnType);
			}

			if (dispType.IsPropertyGet()) {
				return GetProperty(id, out returnType);
			}

			throw new NotSupportedException();
		}

		private object InvokeMethod(DispatchType dispType, DispatchIdentifier id, JsValue[] jsArgs, out Type returnType) {
			// if remote delegate, shouldn't be here, let client side handle that case
			// overridden methods might exist in the properties map, 
			// otherwise try and invoke the method on the target

			MethodBase method = this.targetType.GetMethod(id.AsString);
			if (method == null) {
				object value;
				if (this.properties.TryGetValue(id.AsString, out value)) {
					var del = value as Delegate;
					if (del != null) {
						var args = this.bridge.UnwrapParameters(jsArgs, dispType, del.Method);
						del.DynamicInvoke(args);
					}
				}
				returnType = typeof(void);
				return null;
			}
			else {
				var args = this.bridge.UnwrapParameters(jsArgs, dispType, method);
				returnType = method.IsConstructor ? method.DeclaringType : ((MethodInfo)method).ReturnType;
				return method.Invoke(this.target, args);
			}
		}

		private object GetProperty(DispatchIdentifier id, out Type returnType) {
			object value;
			if (!this.properties.TryGetValue(id.AsString, out value)) {
				var method = this.targetType.GetMethod(id.AsString);
				if (method != null) {
					return GetMethodAsProperty((MethodInfo)method, this.target, out returnType);
				}
				value = null;
				returnType = typeof(void);
			}
			else {
				returnType = value.GetType();
			}
			return value;
		}

		private object SetProperty(DispatchIdentifier id, JsValue[] jsArgs, out Type returnType) {
			//Type targetType;
			//object value;
			//if (this.properties.TryGetValue(id.AsString, out value)) {
			//    targetType = value.GetType();
			//}
			//else {
				// this is needed so that we can make a dummy object instance
			var targetType = typeof(JsNativeHolder);
			//}

			var value = this.bridge.UnwrapValue(jsArgs.First(), targetType);
			this.SetPropertyValue(id.AsString, value);
			//this.bridge.SetDynamicProperty(this.target, id.AsString, value);
			returnType = typeof(void);
			return null;
		}

		public GetTypeResponseMessage GetTypeInfo() {
			var ret = new GetTypeResponseMessage {
				IndexerLength = 0,
				Members = new List<TypeMemberInfo>()
			};

			//var properties = this.bridge.GetDynamicPropertyMap(this.target);
			foreach (var item in this.properties) {
				ret.Members.Add(new TypeMemberInfo {
					DispatchType = DispatchType.PropertyGet | DispatchType.PropertySet,
					//MemberId = 0,
					Name = item.Key
				});
			}

			return ret;
		}

		public object GetPropertyValue(string name) {
			object ret = null;
			this.properties.TryGetValue(name, out ret);
			return ret;
		}

		public void SetPropertyValue(string name, object value) {
			this.properties[name] = value;
		}
	}
}
