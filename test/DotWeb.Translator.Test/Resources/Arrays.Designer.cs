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
    internal class Arrays {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Arrays() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotWeb.Translator.Test.Resources.Arrays", typeof(Arrays).Assembly);
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
        ///   Looks up a localized string similar to Arrays.prototype.CreateArrayOfArrays = function() {
        ///	var inner = [1, 2, 3];
        ///	var CS$0$0000 = new Array(2);
        ///	CS$0$0000[0] = inner;
        ///	CS$0$0000[1] = inner;
        ///	var array = CS$0$0000;
        ///	System.Console.WriteLine$0(array);
        ///};
        ///.
        /// </summary>
        internal static string CreateArrayOfArrays {
            get {
                return ResourceManager.GetString("CreateArrayOfArrays", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrays.prototype.CreateDoubleArray = function() {
        ///	var array = [1.1, 2.2, 3.3];
        ///	System.Console.WriteLine$0(array);
        ///};
        ///.
        /// </summary>
        internal static string CreateDoubleArray {
            get {
                return ResourceManager.GetString("CreateDoubleArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrays.prototype.CreateIntArray = function() {
        ///	var array = [1, 2, 3];
        ///	System.Console.WriteLine$0(array);
        ///};.
        /// </summary>
        internal static string CreateIntArray {
            get {
                return ResourceManager.GetString("CreateIntArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrays.prototype.CreateStringArray = function() {
        ///	var CS$0$0000 = new Array(3);
        ///	CS$0$0000[0] = &quot;one&quot;;
        ///	CS$0$0000[1] = &quot;two&quot;;
        ///	CS$0$0000[2] = &quot;three&quot;;
        ///	var array = CS$0$0000;
        ///	System.Console.WriteLine$0(array);
        ///};
        ///.
        /// </summary>
        internal static string CreateStringArray {
            get {
                return ResourceManager.GetString("CreateStringArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arrays.prototype.EnumArray = function() {
        ///	var array = [1, 2, 3, 4];
        ///	var CS$6$0000 = array;
        ///	var CS$7$0001 = 0;
        ///	while (CS$7$0001 &lt; CS$6$0000.length) {
        ///		var item = CS$6$0000[CS$7$0001];
        ///		System.Console.WriteLine$0(item);
        ///		CS$7$0001 = CS$7$0001 + 1;
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string EnumArray {
            get {
                return ResourceManager.GetString("EnumArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Copyright 2010, Frank Laub
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
        ///// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Source {
            get {
                return ResourceManager.GetString("Source", resourceCulture);
            }
        }
    }
}
