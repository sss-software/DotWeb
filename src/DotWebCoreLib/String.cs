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

using ThisType = System.String;
using System.Text;
using System.Runtime.CompilerServices;
namespace System
{
	[JsNamespace]
	[JsCamelCase]
	[JsAugment("String")]
	public class String
	{
		public static readonly string Empty = "";

		#region Native methods

		/// <summary>
		/// The number of characters in the String value represented by this String object.
		/// </summary>
		/// <remarks>
		/// Once a String object is created, this property is unchanging.
		/// </remarks>
		public extern int Length { get; }

		[JsMacro("{1}")]
		public static extern string Concat(string str1);

		[JsMacro("{1} + {2}")]
		public static extern string Concat(string str1, string str2);

		[JsMacro("{1} + {2}")]
		public static extern string Concat(object obj1, object obj2);

		[JsMacro("{1} + {2} + {3}")]
		public static extern string Concat(string str1, string str2, string str3);

		[JsMacro("{1} + {2} + {3} + {4}")]
		public static extern string Concat(string str1, string str2, string str3, string str4);

		[JsMacro("{1}.join('')")]
		public static extern string Concat(string[] values);

		[JsMacro("{1}.join('')")]
		public static extern string Concat(object[] values);

		[JsMacro("({1} != {2})")]
		public static extern bool operator !=(String lhs, String rhs);

		[JsMacro("({1} == {2})")]
		public static extern bool operator ==(String lhs, String rhs);

		[JsMacro("({0} == {1})")]
		public extern override bool Equals(object obj);

		public extern int IndexOf(string searchString);

		public extern int IndexOf(string searchString, int position);

		public extern int LastIndexOf(string searchString);

		public extern int LastIndexOf(string searchString, int position);

		public extern string Replace(string oldValue, string newValue);

		public extern string Replace(char oldValue, char newValue);

		public extern string Trim();

		[JsName("toLocaleUpperCase")]
		public extern string ToUpper();

		[JsName("toLocaleLowerCase")]
		public extern string ToLower();

		[JsName("toUpperCase")]
		public extern string ToUpperInvariant();

		[JsName("toLowerCase")]
		public extern string ToLowerInvariant();

		[JsName("substring")]
		private extern string NativeSubstring(int start, int end);

		[JsName("split")]
		private extern string[] NativeSplit(object separator);

		[JsName("split")]
		private extern string[] NativeSplit(object separator, int count);
		#endregion

		#region .NET Methods

		[IndexerName("Chars")]
		public extern char this[int index] {
			[JsMacro("{0}.charAt({1})")]
			get;
		}

		[JsCamelCase(false)]
		public override int GetHashCode() {
			int hash = 0;
			for (int i = 0; i < this.Length; i++) {
				int ch = this.CharCodeAt(i);
				hash = (hash << 5) - hash + ch;
			}
			return hash;
		}

		public bool Contains(string value) {
			return IndexOf(value) != -1;
		}

		[JsMacro("{0}.charCodeAt({1})")]
		private extern int CharCodeAt(int pos);


		[JsName("_Substring")]
		public string Substring(int startIndex) {
			if (startIndex == 0)
				return this;
			if (startIndex < 0 || startIndex > this.Length)
				throw new ArgumentOutOfRangeException("startIndex");
			return NativeSubstring(startIndex, this.Length);
		}

		[JsName("_Substring")]
		public string Substring(int startIndex, int length) {
			if (length < 0)
				throw new ArgumentOutOfRangeException("length", "Cannot be negative.");
			if (startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", "Cannot be negative.");
			if (startIndex > this.Length)
				throw new ArgumentOutOfRangeException("startIndex", "Cannot exceed length of string.");
			if (startIndex > this.Length - length)
				throw new ArgumentOutOfRangeException("length", "startIndex + length > this.length");
			if (startIndex == 0 && length == this.Length)
				return this;
			return NativeSubstring(startIndex, startIndex + length);
		}

		[JsName("_Split")]
		public string[] Split(params char[] seperator) {
			if (seperator.Length == 1) {
				return this.NativeSplit(seperator);
			}
			throw new NotSupportedException();
		}

		[JsName("_Split")]
		public string[] Split(char[] seperator, int count) {
			if (seperator.Length == 1) {
				return this.NativeSplit(seperator, count);
			}
			throw new NotSupportedException();
		}

		#region Format

		public static string Format(string format, object arg0) {
			var sb = FormatHelper(null, format, arg0);
			return sb.ToString();
		}

		public static string Format(string format, object arg0, object arg1) {
			var sb = FormatHelper(null, format, arg0, arg1);
			return sb.ToString();
		}

		public static string Format(string format, params object[] args) {
			var sb = FormatHelper(null, format, args);
			return sb.ToString();
		}

		internal static StringBuilder FormatHelper(StringBuilder result, string format, params object[] args) {
			if (format == null)
				throw new ArgumentNullException("format");
			if (args == null)
				throw new ArgumentNullException("args");

			if (result == null) {
				result = new StringBuilder();
			}

			//JsDebug.Log("Format: " + format);

			int ptr = 0;
			int start = ptr;
			while (ptr < format.Length) {
				char ch = format[ptr++];
				//JsDebug.Log(ch);
				if (ch == '{') {
					result.Append(format, start, ptr - start - 1);

					// check for escaped open bracket
					if (format[ptr] == '{') {
						start = ptr++;
						continue;
					}

					// parse specifier
					var specifier = new FormatSpecifier(format, ptr);
					ptr = specifier.ptr;

					if (specifier.n >= args.Length) {
						throw new FormatException("Index (zero based) must be greater than or equal to zero and less than the size of the argument list.");
					}

					// format argument
					object arg = args[specifier.n];

					string str;
					//ICustomFormatter formatter = null;
					//if (provider != null)
					//    formatter = provider.GetFormat(typeof(ICustomFormatter))
					//        as ICustomFormatter;
					if (arg == null)
						str = "";
					//else if (formatter != null)
					//    str = formatter.Format(arg_format, arg, provider);
					//else if (arg is IFormattable)
					//    str = ((IFormattable)arg).ToString(arg_format, provider);
					//else
					str = arg.ToString();

					if (specifier.width > str.Length) {
						const char padchar = ' ';
						int padlen = specifier.width - str.Length;

						if (specifier.left_align) {
							result.Append(str);
							result.Append(padchar, padlen);
						}
						else {
							result.Append(padchar, padlen);
							result.Append(str);
						}
					}
					else
						result.Append(str);

					start = ptr;
				}
				else if (ch == '}' && ptr < format.Length && format[ptr] == '}') {
					result.Append(format, start, ptr - start - 1);
					start = ptr++;
				}
				else if (ch == '}') {
					throw new FormatException("Input string was not in a correct format.");
				}
			}

			if (start < format.Length) {
				result.Append(format, start, format.Length - start);
			}

			return result;
		}

		class FormatSpecifier
		{
			public string str;
			public int ptr;
			public int n;
			public int width;
			public bool left_align;
			public string format;

			public FormatSpecifier(string str, int ptr) {
				this.str = str;
				this.ptr = ptr;
				ParseFormatSpecifier();
			}

			private bool IsWhiteSpace() {
				var ch = str.CharCodeAt(ptr);
				return (ch >= 0x09 && ch <= 0x0d) ||
					ch == 0x20 ||
					ch == 0x85 ||
					ch == 0x205F;
			}

			private void ParseFormatSpecifier() {
				// parses format specifier of form:
				//   N,[\ +[-]M][:F]}
				//
				// where:

				try {
					// N = argument number (non-negative integer)

					n = ParseDecimal();
					if (n < 0)
						throw new FormatException("Invalid argument specifier.");

					// M = width (non-negative integer)

					if (str[ptr] == ',') {
						// White space between ',' and number or sign.
						++ptr;
						while (IsWhiteSpace()) {
							++ptr;
						}
						int start = ptr;
						int len = ptr - start;

						format = str.Substring(start, len);

						left_align = (str[ptr] == '-');
						if (left_align)
							++ptr;

						width = ParseDecimal();
						if (width < 0)
							throw new FormatException("Invalid width specifier.");
					}
					else {
						width = 0;
						left_align = false;
						format = "";
					}

					// F = argument format (string)

					if (str[ptr] == ':') {
						int start = ++ptr;
						while (str[ptr] != '}') {
							++ptr;
						}

						format += str.Substring(start, ptr - start);
					}
					else
						format = null;

					if (str[ptr++] != '}')
						throw new FormatException("Missing end characeter.");
				}
				catch (IndexOutOfRangeException) {
					throw new FormatException("Input string was not in a correct format.");
				}
			}

			private int ParseDecimal() {
				int p = ptr;
				int n = 0;
				while (true) {
					int ch = str.CharCodeAt(p);
					if (ch < '0' || '9' < ch)
						break;

					n = n * 10 + ch - '0';
					++p;
				}

				if (p == ptr)
					return -1;

				ptr = p;
				return n;
			}
		}
		#endregion

		#endregion
	}
}
