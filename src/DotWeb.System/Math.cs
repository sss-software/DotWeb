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

namespace System
{
	[JsNamespace]
	[JsAugment("Math")]
	[JsCamelCase]
	public static class Math
	{
		public const double E = 2.71828;
		public const double PI = 3.14159;

		public static extern double Cos(double a);

		public static extern double Sin(double a);

		public static extern double Sqrt(double d);
	}
}
