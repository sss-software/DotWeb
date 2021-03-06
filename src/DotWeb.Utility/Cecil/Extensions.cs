﻿// Copyright 2010, Frank Laub
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
using Mono.Collections.Generic;
using Mono.Cecil.Cil;

namespace DotWeb.Utility.Cecil
{
	public static class Extensions
	{
		public static Collection<MethodDefinition> GetConstructors(this TypeDefinition type) {
		    var ret = new Collection<MethodDefinition>();
		    foreach (var method in type.Methods) {
		        if (method.IsConstructor)
		            ret.Add(method);
		    }
		    return ret;
		}

		public static Collection<MethodDefinition> GetMethods(this TypeDefinition type, string name) {
		    var ret = new Collection<MethodDefinition>();
		    foreach (var method in type.Methods) {
		        if (method.Name == name)
		            ret.Add(method);
		    }
		    return ret;
		}

		public static Collection<MethodDefinition> GetMethods(this TypeDefinition type)
		{
		    var ret = new Collection<MethodDefinition>();
		    foreach (var method in type.Methods) {
				if(!method.IsConstructor)
					ret.Add(method);
		    }
		    return ret;
		}

		public static MethodDefinition GetStaticConstructor(this TypeDefinition type) {
			return type.Methods.FirstOrDefault(x => x.IsConstructor && x.IsStatic);
		}

		public static MethodDefinition GetConstructor(this TypeDefinition type, TypeReference[] parameterTypes) {
			var ctors = type.GetConstructors();
			return ctors.SingleOrDefault(x => ParameterTypesMatch(x.Parameters, parameterTypes));
		}

		private static bool ParameterTypesMatch(Collection<ParameterDefinition> lhs, TypeReference[] rhs) {
			if (rhs == null)
				return lhs.Count == 0;

			if (lhs.Count != rhs.Length)
				return false;

			for (int i = 0; i < lhs.Count; i++) {
				if (lhs[i].ParameterType != rhs[i])
					return false;
			}

			return true;
		}

		public static string GetName(this VariableReference variable) {
			if (string.IsNullOrEmpty(variable.Name))
				return "V_" + variable.Index;
			return variable.Name;
		}
	}
}