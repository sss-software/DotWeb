﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotWeb.Translator.Test.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotWeb.Translator.Test.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace H8
        ///{
        ///	class SourceTests
        ///	{
        ///		/// &lt;summary&gt;
        ///		/// .method public hidebysig instance void  HelloWorld() cil managed
        ///		/// {
        ///		///  // Code size       13 (0xd)
        ///		///  .maxstack  8
        ///		///  IL_0000:  nop
        ///		///  IL_0001:  ldstr      &quot;Hello World!&quot;
        ///		///  IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
        ///		///  IL_000b:  nop
        ///		///  IL_000c:  ret
        ///		/// } // end of method Program::He [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SourceTests {
            get {
                return ResourceManager.GetString("SourceTests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.AnonymousType = function() {
        ///	var loc0 = new __f__AnonymousType0$2().$ctor(&quot;Hi&quot;, 1);
        ///	console.log(&quot;{0}: {1}&quot;, loc0.Key.Length, loc0.Value);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_AnonymousType {
            get {
                return ResourceManager.GetString("SourceTests_AnonymousType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.Callback = function(del /*H8.SourceTests_SimpleDelegate*/) {
        ///	if (del) {
        ///		del.Invoke();
        ///	}
        ///	if (this.SimpleEvent) {
        ///		this.SimpleEvent.Invoke();
        ///	}
        ///	this.SimpleEvent = /*(H8.SourceTests_SimpleDelegate)*/System.Delegate.Combine(this.SimpleEvent, this.SourceTests_SimpleEvent);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_Callback {
            get {
                return ResourceManager.GetString("SourceTests_Callback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.Cifuentes = function() {
        ///	var loc0 = 5;
        ///	var loc1 = loc0 * 5;
        ///	if (loc0 &lt; loc1) {
        ///		loc0 = loc0 * loc1;
        ///		if ((loc0 * 2) &lt;= loc1) {
        ///			loc1 = loc1 &lt;&lt; 3;
        ///		}
        ///		else {
        ///			loc0 = loc0 &lt;&lt; 3;
        ///		}
        ///	}
        ///	var loc2 = 0;
        ///	while(loc2 &lt; 10) {
        ///		var loc3 = loc2;
        ///		do {
        ///			loc3 = loc3 + 1;
        ///			console.log(&quot;{0}, {1}&quot;, loc2, loc3);
        ///		} while(loc3 &lt; 5);
        ///		loc2 = loc2 + 1;
        ///	}
        ///	if ((loc0 &lt; loc1) || ((loc1 * 2) &gt; loc0)) {
        ///		loc0 = (loc0 + loc1) - 10;
        ///		loc1 = loc1 / 2;
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_Cifuentes {
            get {
                return ResourceManager.GetString("SourceTests_Cifuentes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.CreateObject = function() {
        ///	var loc0 = new H8.SourceTests_Test().$ctor(&quot;Test1&quot;, 1);
        ///	var loc2 = new H8.SourceTests_Test().$ctor();
        ///	loc2.Text = &quot;Test2&quot;;
        ///	loc2.Value = 2;
        ///	var loc1 = loc2;
        ///	console.log(&quot;{0}, {1}&quot;, loc0.Text, loc0.Value);
        ///	console.log(&quot;{0}, {1}&quot;, loc1.Text, loc1.Value);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_CreateObject {
            get {
                return ResourceManager.GetString("SourceTests_CreateObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.DoWhileLoop = function() {
        ///	var loc0 = 0;
        ///	do {
        ///		console.log(loc0);
        ///		loc0 = loc0 + 1;
        ///	} while(loc0 &lt; 10);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_DoWhileLoop {
            get {
                return ResourceManager.GetString("SourceTests_DoWhileLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.EnumArray = function() {
        ///	System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(new System.Int32[4], [ 1, 2, 3, 4 ]);
        ///	var loc0 = new System.Int32[4];
        ///	var loc2 = loc0;
        ///	var loc3 = 0;
        ///	while(loc3 &lt; loc2.length) {
        ///		var loc1 = loc2[loc3];
        ///		console.log(loc1);
        ///		loc3 = loc3 + 1;
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_EnumArray {
            get {
                return ResourceManager.GetString("SourceTests_EnumArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.ForLoop = function() {
        ///	var loc0 = 0;
        ///	while(loc0 &lt; 10) {
        ///		console.log(loc0);
        ///		loc0 = loc0 + 1;
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_ForLoop {
            get {
                return ResourceManager.GetString("SourceTests_ForLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.HelloWorld = function() {
        ///	console.log(&quot;Hello World!&quot;);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_HelloWorld {
            get {
                return ResourceManager.GetString("SourceTests_HelloWorld", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.If = function() {
        ///	var loc0 = 0;
        ///	if (loc0 == 1) {
        ///		console.log(&quot;True&quot;);
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_If {
            get {
                return ResourceManager.GetString("SourceTests_If", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.IfElse = function() {
        ///	var loc0 = 0;
        ///	if (loc0 == 1) {
        ///		console.log(&quot;True&quot;);
        ///	}
        ///	else {
        ///		console.log(&quot;False&quot;);
        ///	}
        ///	console.log(&quot;Yep&quot;);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_IfElse {
            get {
                return ResourceManager.GetString("SourceTests_IfElse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.IfElseIf = function() {
        ///	var loc0 = 0;
        ///	if (loc0 == 1) {
        ///		console.log(&quot;True&quot;);
        ///		return;
        ///	}
        ///	else {
        ///		if (loc0 == 2) {
        ///			console.log(&quot;False&quot;);
        ///		}
        ///		return;
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_IfElseIf {
            get {
                return ResourceManager.GetString("SourceTests_IfElseIf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.IfIf = function() {
        ///	var loc0 = 0;
        ///	if (loc0 == 1) {
        ///		console.log(&quot;True&quot;);
        ///	}
        ///	if (loc0 == 2) {
        ///		console.log(&quot;False&quot;);
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_IfIf {
            get {
                return ResourceManager.GetString("SourceTests_IfIf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.Linq = function() {
        ///	var loc0 = &quot;ABCDE99F-J74-12-89A&quot;;
        ///	if (!H8.SourceTests.CS$__9__CachedAnonymousMethodDelegate2) {
        ///		H8.SourceTests.CS$__9__CachedAnonymousMethodDelegate2 = H8.SourceTests._Linq_b__1;
        ///	}
        ///	var loc1 = System.Linq.Enumerable.Where(loc0, H8.SourceTests.CS$__9__CachedAnonymousMethodDelegate2);
        ///	var loc3 = loc1.GetEnumerator();
        ///	while(loc3.MoveNext()) {
        ///		var loc2 = loc3.Current;
        ///		console.log(loc2);
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_Linq {
            get {
                return ResourceManager.GetString("SourceTests_Linq", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.Switch = function(val /*System.Int32*/) {
        ///	console.log(&quot;Hello&quot;);
        ///	var loc0 = val;
        ///	switch(loc0 - 1) {
        ///		default:
        ///			console.log(&quot;default&quot;);
        ///			break;
        ///		case 0:
        ///			console.log(&quot;1&quot;);
        ///			break;
        ///		case 1:
        ///			console.log(&quot;2&quot;);
        ///			break;
        ///		case 2:
        ///			console.log(&quot;3&quot;);
        ///			break;
        ///		case 3:
        ///		case 4:
        ///			console.log(&quot;4, 5&quot;);
        ///			break;
        ///	}
        ///	console.log(&quot;Bye&quot;);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_Switch {
            get {
                return ResourceManager.GetString("SourceTests_Switch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.TakeParameters = function(str /*System.String*/, value /*System.Int32*/, rad /*System.Double[]*/) {
        ///	console.log(str);
        ///	var loc0 = System.Math.Sin(rad[value] * 1.5707963267949);
        ///	return System.Math.Cosh(loc0);
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_TakeParameters {
            get {
                return ResourceManager.GetString("SourceTests_TakeParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.WhileBreakLoop = function() {
        ///	var loc0 = 0;
        ///	while(loc0 != 10) {
        ///		console.log(loc0);
        ///		loc0 = loc0 + 1;
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_WhileBreakLoop {
            get {
                return ResourceManager.GetString("SourceTests_WhileBreakLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.WhileCondBreakLoop = function() {
        ///	var loc0 = 0;
        ///	while(loc0 &lt; 9) {
        ///		if (loc0 == 10) {
        ///			return;
        ///		}
        ///		else {
        ///			console.log(loc0);
        ///			loc0 = loc0 + 1;
        ///		}
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_WhileCondBreakLoop {
            get {
                return ResourceManager.GetString("SourceTests_WhileCondBreakLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.SourceTests.prototype.WhileLoop = function() {
        ///	var loc0 = 0;
        ///	while(loc0 &lt; 10) {
        ///		console.log(loc0);
        ///		loc0 = loc0 + 1;
        ///	}
        ///};
        ///
        ///.
        /// </summary>
        internal static string SourceTests_WhileLoop {
            get {
                return ResourceManager.GetString("SourceTests_WhileLoop", resourceCulture);
            }
        }
    }
}
