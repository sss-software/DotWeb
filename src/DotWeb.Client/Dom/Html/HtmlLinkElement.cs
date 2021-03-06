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
	public class HtmlLinkElement : HtmlElement
	{
		public extern bool disabled { get; set; }
		public extern string charset { get; set; }
		public extern string href { get; set; }
		public extern string hreflang { get; set; }
		public extern string media { get; set; }
		public extern string rel { get; set; }
		public extern string rev { get; set; }
		public extern string target { get; set; }
		public extern string type { get; set; }
	}
}