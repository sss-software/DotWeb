﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotWeb.Translator.Test {
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
    internal class Loops {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Loops() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotWeb.Translator.Test.Loops", typeof(Loops).Assembly);
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
        ///   Looks up a localized string similar to Loops.prototype.BreakInWhile = function(/*System.Int32*/ a) {
        ///	while(a &lt; 100) {
        ///		if (a == 12) {
        ///			System.Console.WriteLine(a);
        ///			break;
        ///		}
        ///		else {
        ///			System.Console.WriteLine(a);
        ///		}
        ///		a = a - 1;
        ///	}
        ///	System.Console.WriteLine(a);
        ///};
        ///.
        /// </summary>
        internal static string BreakInWhile {
            get {
                return ResourceManager.GetString("BreakInWhile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.ComplexLoop = function() {
        ///	var i = 0;
        ///	while(i &lt; 9) {
        ///		if (i == 10) {
        ///			System.Console.WriteLine(i);
        ///			break;
        ///		}
        ///		else {
        ///			System.Console.WriteLine(i);
        ///			i = i + 1;
        ///		}
        ///		System.Console.WriteLine(i);
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string ComplexLoop {
            get {
                return ResourceManager.GetString("ComplexLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.ComplexNestedLoop = function() {
        ///	var i = 0;
        ///	while(i &lt; 9) {
        ///		if (i == 10) {
        ///			System.Console.WriteLine(i);
        ///			break;
        ///		}
        ///		else {
        ///			System.Console.WriteLine(i);
        ///			i = i + 1;
        ///		}
        ///		System.Console.WriteLine(i);
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string ComplexNestedLoop {
            get {
                return ResourceManager.GetString("ComplexNestedLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.EndlessLoop = function() {
        ///	System.Console.WriteLine(&quot;enter&quot;);
        ///	while(true) {
        ///		System.Console.WriteLine(&quot;loop&quot;);
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string EndlessLoop {
            get {
                return ResourceManager.GetString("EndlessLoop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.MultiReturns = function() {
        ///	var i = 0;
        ///	while(i &lt; 9) {
        ///		if (i == 10) {
        ///			System.Console.WriteLine(i);
        ///			break;
        ///		}
        ///		else {
        ///			System.Console.WriteLine(i);
        ///			i = i + 1;
        ///		}
        ///		System.Console.WriteLine(i);
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string MultiReturns {
            get {
                return ResourceManager.GetString("MultiReturns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.MultiReturns2 = function() {
        ///	var i = 0;
        ///	while(i &lt; 9) {
        ///		if (i == 10) {
        ///			System.Console.WriteLine(i);
        ///			break;
        ///		}
        ///		else {
        ///			System.Console.WriteLine(i);
        ///			i = i + 1;
        ///		}
        ///		System.Console.WriteLine(i);
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string MultiReturns2 {
            get {
                return ResourceManager.GetString("MultiReturns2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.NestedDoWhile = function(/*System.Int32*/ a) {
        ///	while(a &lt; 100) {
        ///		do {
        ///			a = a * 10;
        ///		} while(a &lt; 10);
        ///		a = a + 2;
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string NestedDoWhile {
            get {
                return ResourceManager.GetString("NestedDoWhile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.SimpleDoWhile = function(/*System.Int32*/ a) {
        ///	System.Console.WriteLine(a);
        ///	do {
        ///		a = a + 1;
        ///		System.Console.WriteLine(a);
        ///	} while(a &lt; 100);
        ///	System.Console.WriteLine(a);
        ///};
        ///.
        /// </summary>
        internal static string SimpleDoWhile {
            get {
                return ResourceManager.GetString("SimpleDoWhile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.SimpleFor = function(/*System.Int32*/ a) {
        ///	var i = 0;
        ///	while(i &lt; 10) {
        ///		a = a + 1;
        ///		i = i + 1;
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string SimpleFor {
            get {
                return ResourceManager.GetString("SimpleFor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.SimpleWhile = function(/*System.Int32*/ a) {
        ///	System.Console.WriteLine(a);
        ///	while(a &lt; 100) {
        ///		a = a + 1;
        ///		System.Console.WriteLine(a);
        ///	}
        ///	System.Console.WriteLine(a);
        ///};
        ///.
        /// </summary>
        internal static string SimpleWhile {
            get {
                return ResourceManager.GetString("SimpleWhile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.DotWeb;
        ///using System;
        ///
        ///namespace H8
        ///{
        ///	[JsNamespace]
        ///	class Loops
        ///	{
        ///		public void SimpleFor(int a) {
        ///			for (int i = 0; i &lt; 10; i++) {
        ///				a++;
        ///			}
        ///		}
        ///
        ///		public void SimpleDoWhile(int a) {
        ///			Console.WriteLine(a);
        ///			do {
        ///				a++;
        ///				Console.WriteLine(a);
        ///			} while (a &lt; 100);
        ///			Console.WriteLine(a);
        ///		}
        ///
        ///		public void SimpleWhile(int a) {
        ///			Console.WriteLine(a);
        ///			while (a &lt; 100) {
        ///				a++;
        ///				Console.WriteLine(a);
        ///			}
        ///			Console.WriteLine(a);
        ///		}
        ///
        ///		pu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Source {
            get {
                return ResourceManager.GetString("Source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.WhileBreak = function() {
        ///	var i = 0;
        ///	while(true) {
        ///		System.Console.WriteLine(&quot;top&quot;);
        ///		if (i == 10) {
        ///			break;
        ///		}
        ///		System.Console.WriteLine(&quot;loop&quot;);
        ///		i = i + 1;
        ///	}
        ///	System.Console.WriteLine(&quot;break&quot;);
        ///	System.Console.WriteLine(&quot;exit&quot;);
        ///};
        ///.
        /// </summary>
        internal static string WhileBreak {
            get {
                return ResourceManager.GetString("WhileBreak", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.WhileBreakBreak = function() {
        ///	var i = 0;
        ///	while(true) {
        ///		System.Console.WriteLine(&quot;top&quot;);
        ///		if (i == 10) {
        ///			System.Console.WriteLine(&quot;break1&quot;);
        ///			break;
        ///		}
        ///		if (i == 5) {
        ///			System.Console.WriteLine(&quot;break2&quot;);
        ///			break;
        ///		}
        ///		System.Console.WriteLine(&quot;bottom&quot;);
        ///		i = i + 1;
        ///	}
        ///	System.Console.WriteLine(&quot;exit&quot;);
        ///};
        ///.
        /// </summary>
        internal static string WhileBreakBreak {
            get {
                return ResourceManager.GetString("WhileBreakBreak", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.WhileBreakContinue = function() {
        ///	var i = 0;
        ///	while(true) {
        ///		System.Console.WriteLine(&quot;top&quot;);
        ///		if(i == 10) {
        ///			System.Console.WriteLine(&quot;continue&quot;);
        ///			continue;
        ///		}
        ///		if (i == 20) {
        ///			System.Console.WriteLine(&quot;break&quot;);
        ///			break;
        ///		}
        ///		System.Console.WriteLine(&quot;bottom&quot;);
        ///		i = i + 1;
        ///	}
        ///	System.Console.WriteLine(&quot;exit&quot;);
        ///};
        ///.
        /// </summary>
        internal static string WhileBreakContinue {
            get {
                return ResourceManager.GetString("WhileBreakContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.WhileCondBreak = function() {
        ///	var i = 0;
        ///	while(i &lt; 9) {
        ///		if (i == 10) {
        ///			System.Console.WriteLine(i);
        ///			break;
        ///		}
        ///		else {
        ///			System.Console.WriteLine(i);
        ///			i = i + 1;
        ///		}
        ///		System.Console.WriteLine(i);
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string WhileCondBreak {
            get {
                return ResourceManager.GetString("WhileCondBreak", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.WhileCondBreak = function() {
        ///	var i = 0;
        ///	while(i &lt; 9) {
        ///		if (i == 10) {
        ///			System.Console.WriteLine(i);
        ///			break;
        ///		}
        ///		else {
        ///			System.Console.WriteLine(i);
        ///			i = i + 1;
        ///		}
        ///		System.Console.WriteLine(i);
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string WhileCondContinue {
            get {
                return ResourceManager.GetString("WhileCondContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loops.prototype.WhileContinue = function() {
        ///	var i = 0;
        ///	while(true) {
        ///		System.Console.WriteLine(&quot;top&quot;);
        ///		if(i == 10) {
        ///			System.Console.WriteLine(&quot;continue&quot;);
        ///			continue;
        ///		}
        ///		System.Console.WriteLine(&quot;bottom&quot;);
        ///		i = i + 1;
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string WhileContinue {
            get {
                return ResourceManager.GetString("WhileContinue", resourceCulture);
            }
        }
    }
}
