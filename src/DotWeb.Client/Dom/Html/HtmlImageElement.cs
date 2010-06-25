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
namespace DotWeb.Client.Dom.Html
{
	[JsIntrinsic]
	public class HtmlImageElement : HtmlElement
	{
		public extern string name { get; set; }
		public extern string align { get; set; }
		public extern string alt { get; set; }
		public extern string border { get; set; }
		public extern int height { get; set; }
		public extern int hspace { get; set; }
		public extern bool isMap { get; set; }
		public extern string longDesc { get; set; }
		public extern string src { get; set; }
		public extern string useMap { get; set; }
		public extern int vspace { get; set; }
		public extern int width { get; set; }
	}
}