﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotWeb.Translator.Test.Resources {
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
    internal class Decoration {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Decoration() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotWeb.Translator.Test.Resources.Decoration", typeof(Decoration).Assembly);
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
        ///   Looks up a localized string similar to // Copyright 2009, Frank Laub
        /////
        ///// This file is part of DotWeb.
        /////
        ///// DotWeb is free software: you can redistribute it and/or modify
        ///// it under the terms of the GNU General Public License as published by
        ///// the Free Software Foundation, either version 3 of the License, or
        ///// (at your option) any later version.
        /////
        ///// DotWeb is distributed in the hope that it will be useful,
        ///// but WITHOUT ANY WARRANTY; without even the implied warranty of
        ///// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.   [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Source {
            get {
                return ResourceManager.GetString("Source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $Class(null, &apos;System&apos;, &apos;Console&apos;);
        ///
        ///System.Console.WriteLine$0 = function(value) {
        ///	console.log(value);
        ///};
        ///
        ///$Class(null, &apos;H8&apos;, &apos;DecorationTests&apos;);
        ///
        ///H8.DecorationTests.prototype.TestJsAnonymous = function() {
        ///	var __g__initLocal0 = {};
        ///	__g__initLocal0.X = 1;
        ///	__g__initLocal0.y = 2;
        ///	var item = __g__initLocal0;
        ///	item.X = item.y;
        ///	item.y = item.X;
        ///	var CS$0$0000 = new Array(2);
        ///	var __g__initLocal1 = {};
        ///	__g__initLocal1.X = 0;
        ///	__g__initLocal1.y = 0;
        ///	CS$0$0000[0] = __g__initLocal1;
        ///	var  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestJsAnonymous {
            get {
                return ResourceManager.GetString("TestJsAnonymous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.DecorationTests.prototype.TestJsCamelCase = function() {
        ///	var x = new H8.CamelCaseTest().$ctor();
        ///	x.foo();
        ///	this.camelCase();
        ///};
        ///.
        /// </summary>
        internal static string TestJsCamelCase {
            get {
                return ResourceManager.GetString("TestJsCamelCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.DecorationTests.prototype.TestJsCode = function(arg) {
        ///	alert(arg);
        ///};
        ///.
        /// </summary>
        internal static string TestJsCode {
            get {
                return ResourceManager.GetString("TestJsCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $Class(null, &apos;H8&apos;, &apos;IntrinsicClass&apos;);
        ///
        ///H8.IntrinsicClass.prototype.$ctor = function() {
        ///	return this;
        ///};
        ///
        ///$Class(null, &apos;System&apos;, &apos;Console&apos;);
        ///
        ///System.Console.Write = function(value) {
        ///	console.log(value);
        ///};
        ///
        ///$Class(null, &apos;H8&apos;, &apos;DecorationTests&apos;);
        ///
        ///H8.DecorationTests.prototype.TestJsIntrinsic = function() {
        ///	var __g__initLocal3 = new H8.IntrinsicClass().$ctor();
        ///	__g__initLocal3.Value = 1;
        ///	var item = __g__initLocal3;
        ///	System.Console.Write(item.Value);
        ///};
        ///.
        /// </summary>
        internal static string TestJsIntrinsic {
            get {
                return ResourceManager.GetString("TestJsIntrinsic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to H8.DecorationTests.prototype.TestJsMacro = function() {
        ///	this.jQuery(&quot;*&quot;);
        ///	H8.DecorationTests.jQuery(&quot;*&quot;);
        ///	H8.DecorationTests.TakeJQuery(this.jQuery(&quot;#id&quot;));
        ///	System.Console.WriteLine$0($doc.getElementById(&quot;id&quot;));
        ///	System.Console.WriteLine$0(this.charAt(0));
        ///};
        ///.
        /// </summary>
        internal static string TestJsMacro {
            get {
                return ResourceManager.GetString("TestJsMacro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to $Class(null, &apos;&apos;, &apos;DefaultNamespaceTest&apos;);
        ///
        ///DefaultNamespaceTest.prototype.$ctor = function() {
        ///	return this;
        ///};
        ///
        ///DefaultNamespaceTest.prototype.set_Value = function(value) {
        ///	this._Value_k__BackingField = value;
        ///};
        ///
        ///$Class(null, &apos;Foo&apos;, &apos;FooNamespaceTest&apos;);
        ///
        ///Foo.FooNamespaceTest.prototype.$ctor = function() {
        ///	return this;
        ///};
        ///
        ///DefaultNamespaceTest.prototype.get_Value = function() {
        ///	return this._Value_k__BackingField;
        ///};
        ///
        ///Foo.FooNamespaceTest.prototype.set_Value = function(value) {
        ///	this [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestJsNamespace {
            get {
                return ResourceManager.GetString("TestJsNamespace", resourceCulture);
            }
        }
    }
}
