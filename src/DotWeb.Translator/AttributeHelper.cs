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
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;
using DotWeb.Utility.Cecil;

namespace DotWeb.Translator
{
	public static class AttributeHelper
	{
		public static string GetJsCode(MethodDefinition method) {
			var customAttr = FindByName(method, JsCode);
			if (customAttr != null) {
				var args = customAttr.ConstructorParameters;
				return (string)args[0];
			}
			return null;
		}

		public static string GetJsMacro(MethodDefinition method) {
			var customAttr = FindByName(method, JsMacro);
			if (customAttr != null) {
				var args = customAttr.ConstructorParameters;
				return (string)args[0];
			}
			return null;
		}

		public static string GetJsNamespace(TypeReference typeRef) {
			var customAttr = FindByName(typeRef, JsNamespace);
			if (customAttr != null) {
				var args = customAttr.ConstructorParameters;
				if (args.Count == 1)
					return (string)args[0];
				return "";
			}
			return null;
		}

		public static bool IsCamelCase(MemberReference memberRef) {
			if (memberRef is FieldReference) {
				return IsCamelCase((FieldReference)memberRef);
			}
			if (memberRef is MethodReference) {
				return IsCamelCase((MethodReference)memberRef);
			}
			if (memberRef is PropertyReference) {
				return IsCamelCase((PropertyReference)memberRef);
			}
			return false;
		}

		public static bool IsCamelCase(FieldReference fieldRef) {
			return
				TypeHelper.IsDefined(fieldRef.Resolve(), JsCamelCase) ||
				TypeHelper.IsDefined(fieldRef.DeclaringType.Resolve(), JsCamelCase);
		}

		public static bool IsCamelCase(MethodReference methodRef) {
			return
				TypeHelper.IsDefined(methodRef.Resolve(), JsCamelCase) ||
				TypeHelper.IsDefined(methodRef.DeclaringType.Resolve(), JsCamelCase);
		}

		public static bool IsCamelCase(PropertyReference propertyRef) {
			return
				TypeHelper.IsDefined(propertyRef.Resolve(), JsCamelCase) ||
				TypeHelper.IsDefined(propertyRef.DeclaringType.Resolve(), JsCamelCase);
		}

		public static bool IsAnonymous(TypeReference type) {
			return TypeHelper.IsDefined(type.Resolve(), JsAnonymous);
		}

		public static bool IsIntrinsic(PropertyReference propertyRef) {
			return
				TypeHelper.IsDefined(propertyRef.Resolve(), JsInstrinsic) ||
				TypeHelper.IsDefined(propertyRef.DeclaringType.Resolve(), JsInstrinsic);
		}

		private static CustomAttribute FindByName(ICustomAttributeProvider provider, string typeName) {
			if (provider.HasCustomAttributes) {
				foreach (CustomAttribute item in provider.CustomAttributes) {
					if (item.Constructor.DeclaringType.FullName == typeName)
						return item;
				}
			}
			return null;
		}

		private const string JsNamespace = "System.DotWeb.JsNamespaceAttribute";
		private const string JsCode = "System.DotWeb.JsCodeAttribute";
		private const string JsMacro = "System.DotWeb.JsMacroAttribute";
		private const string JsInstrinsic = "System.DotWeb.JsIntrinsicAttribute";
		private const string JsCamelCase = "System.DotWeb.JsCamelCaseAttribute";
		private const string JsAnonymous = "System.DotWeb.JsAnonymousAttribute";
	}
}
