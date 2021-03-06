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

namespace DotWeb.Client.Dom.Events
{
	public interface MouseEvent : UiEvent
	{
		int screenX { get; }
		int screenY { get; }
		int clientX { get; }
		int clientY { get; }
		bool ctrlKey { get; }
		bool shiftKey { get; }
		bool altKey { get; }
		bool metaKey { get; }
		ushort button { get; }
		EventTarget relatedTarget { get; }

		void initMouseEvent(
			string type,
			bool canBubble,
			bool cancelable,
			object /*views::AbstractView*/ view,
			int detail,
			int screenX,
			int screenY,
			int clientX,
			int clientY,
			bool ctrlKey,
			bool altKey,
			bool shiftKey,
			bool metaKey,
			ushort button,
			EventTarget relatedTarget);
	}

	public delegate void MouseEventHandler(MouseEvent evt);
}
