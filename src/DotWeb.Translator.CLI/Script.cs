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
using DotWeb.Client;
using Ext;
using Ext.grid;
using Ext.data;

namespace H8.CLI
{
	public class IndexScript
	{
		private int id = NextId();
		private GridPanel grid;

		private static int counter = 0;
		private static int NextId() {
			return counter++;
		}

		[JsAnonymous]
		class Schema
		{
			public string name;
			public string type;
		}

		[JsAnonymous]
		class MyRecord
		{
			public int id;
			public string value;
		}

		public IndexScript() {
			Console.WriteLine("IndexScript()");

			Delegate record = null; Record.create(new Schema[] {
				new Schema { name = "id", type = "int" },
				new Schema { name = "value" }
			});

			JsonReader reader = new JsonReader(new JsonReaderConfig {
				id = "id"
			}, record);
			Console.WriteLine(reader);

			Store store = new Store(new StoreConfig {
				reader = reader
			});

			var data = new MyRecord[] {
				new MyRecord { id = 1, value = "first" },
				new MyRecord { id = 2, value = "second" }
			};
			Console.WriteLine(data);
			store.loadData(data);

			ColumnModelConfig[] columns = new ColumnModelConfig[] {
				new ColumnModelConfig {
					dataIndex = "id", header = "ID"
				},
				new ColumnModelConfig {
					dataIndex = "value", header = "Value"
				}
			};

			this.grid = new GridPanel(new GridPanelConfig {
				height = 150,
				renderTo = "grid",
				colModel = new ColumnModel(columns),
				store = store
			});
			Console.WriteLine(this.grid);

			this.grid.on("dblclick", new GridPanelDblclickDelegate(this.OnDblClick), this);
		}

		private void OnDblClick(Ext.EventObject e) {
			Console.WriteLine("DblClick");
			Console.WriteLine(e);
			Console.WriteLine(this);
		}
	}
}
