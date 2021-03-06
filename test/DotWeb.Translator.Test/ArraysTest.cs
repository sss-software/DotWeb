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
using NUnit.Framework;
using Mono.Cecil;

namespace DotWeb.Translator.Test
{
	[TestFixture]
	public class ArraysTest : TestBase
	{
		public ArraysTest()
			: base("DotWeb.Translator.Test.Script", "H8.Arrays", Resources.Arrays.ResourceManager, "Source") {
		}

		[Test]
		public void CreateIntArray() { this.RunTest(); }

		[Test]
		public void CreateDoubleArray() { this.RunTest(); }
	
		[Test]
		public void CreateStringArray() { this.RunTest(); }
		
		[Test]
		public void CreateArrayOfArrays() { this.RunTest(); }

		[Test]
		public void EnumArray() { this.RunTest(); }
	}
}
