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
using System.Text;
using Mono.Cecil;

namespace DotWeb.Decompiler.CodeModel
{
	public class CodeTypeDeclaration : CodeTypeMember
	{
		public CodeTypeDeclaration() {
			this.Methods = new List<CodeMethodMember>();
			this.Fields = new List<CodeFieldMember>();
			this.Events = new List<CodeEventMember>();
			this.Properties = new List<CodePropertyMember>();
			this.ExternalTypes = new List<Type>();
		}

		#region Visitor Pattern
		public override void Accept<V>(V visitor) {
			((ICodeVisitor<CodeTypeDeclaration>)visitor).Visit(this);
		}

		public override R Accept<V, R>(V visitor) {
			return ((ICodeVisitor<CodeTypeDeclaration, R>)visitor).VisitReturn(this);
		}
		#endregion

		public TypeDefinition Type { get; set; }
		public string Name { get { return this.Type.Name; } }
		public string FullName { get { return this.Type.FullName; } }

		public List<CodeMethodMember> Methods { get; set; }
		public List<CodeFieldMember> Fields { get; set; }
		public List<CodeEventMember> Events { get; set; }
		public List<CodePropertyMember> Properties { get; set; }
		public List<Type> ExternalTypes { get; set; }
	}
}
