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
    internal class GraphBuilderTestData {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GraphBuilderTestData() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotWeb.Translator.Test.Resources.GraphBuilderTestData", typeof(GraphBuilderTestData).Assembly);
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
        ///   Looks up a localized string similar to B1: 0000 - 0005: throw &lt;Throw&gt;
        ///	0000: newobj instance [return: System.Void] System.ArgumentException::.ctor() &lt;Call&gt;
        ///	0005: throw &lt;Throw&gt;
        ///
        ///B2: 0006 - 0018: leave.s 0020 &lt;Branch&gt;
        ///	Out: B3
        ///	0006: stloc.0 &lt;Next&gt;
        ///	0007: ldloc.0 &lt;Next&gt;
        ///	0008: callvirt instance [return: System.String] System.Exception::get_Message() &lt;Call&gt;
        ///	0013: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	0018: leave.s 0020 &lt;Branch&gt;
        ///
        ///B3: 0020 - 0020: ret &lt;Return&gt;
        ///	In : B2
        ///	0020: ret &lt;Return&gt;
        ///.
        /// </summary>
        internal static string ArgumentException {
            get {
                return ResourceManager.GetString("ArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to B1: 0000 - 0000: ret &lt;Return&gt;
        ///	0000: ret &lt;Return&gt;.
        /// </summary>
        internal static string NullBlock {
            get {
                return ResourceManager.GetString("NullBlock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to B1: 0000 - 0010: ret &lt;Return&gt;
        ///	0000: ldstr &quot;hello&quot; &lt;Next&gt;
        ///	0005: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	0010: ret &lt;Return&gt;.
        /// </summary>
        internal static string OneBlock {
            get {
                return ResourceManager.GetString("OneBlock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to B1: 0000 - 0001: brfalse.s 0013 &lt;Cond_Branch&gt;
        ///	Out: B2, B3
        ///	0000: ldarg.1 &lt;Next&gt;
        ///	0001: brfalse.s 0013 &lt;Cond_Branch&gt;
        ///
        ///B2: 0003 - 0008: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	In : B1
        ///	Out: B3
        ///	0003: ldstr &quot;x&quot; &lt;Next&gt;
        ///	0008: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///
        ///B3: 0013 - 0013: ret &lt;Return&gt;
        ///	In : B1, B2
        ///	0013: ret &lt;Return&gt;
        ///.
        /// </summary>
        internal static string SimpleIf {
            get {
                return ResourceManager.GetString("SimpleIf", resourceCulture);
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
        
        /// <summary>
        ///   Looks up a localized string similar to B1: 0000 - 0013: switch [0032, 0044, 0044] &lt;Cond_Branch&gt;
        ///	Out: B2, B3, B4
        ///	0000: ldstr &quot;enter&quot; &lt;Next&gt;
        ///	0005: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	0010: ldarg.1 &lt;Next&gt;
        ///	0011: stloc.0 &lt;Next&gt;
        ///	0012: ldloc.0 &lt;Next&gt;
        ///	0013: switch [0032, 0044, 0044] &lt;Cond_Branch&gt;
        ///
        ///B4: 0044 - 0054: br.s 0066 &lt;Branch&gt;
        ///	In : B1
        ///	Out: B6
        ///	0044: ldstr &quot;One &amp; Two&quot; &lt;Next&gt;
        ///	0049: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	0054: br.s 0066 &lt;Branch&gt;
        ///
        ///B3: 0032 - 0042: br.s 0066 &lt;B [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Switch {
            get {
                return ResourceManager.GetString("Switch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to B1: 0000 - 0005: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	Out: B2
        ///	0000: ldstr &quot;enter&quot; &lt;Next&gt;
        ///	0005: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///
        ///B2: 0010 - 0021: brfalse.s 0029 &lt;Cond_Branch&gt;
        ///	In : B1
        ///	Out: B3, B4
        ///	0010: ldstr &quot;try begin&quot; &lt;Next&gt;
        ///	0015: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	0020: ldarg.1 &lt;Next&gt;
        ///	0021: brfalse.s 0029 &lt;Cond_Branch&gt;
        ///
        ///B4: 0029 - 0039: leave.s 0089 &lt;Branch&gt;
        ///	In : B2
        ///	Out: B7
        ///	0029: ldstr &quot;try end&quot; &lt;N [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TryCatchFinally {
            get {
                return ResourceManager.GetString("TryCatchFinally", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to B1: 0000 - 0001: stloc.0 &lt;Next&gt;
        ///	Out: B2
        ///	0000: ldc.i4.0 &lt;Next&gt;
        ///	0001: stloc.0 &lt;Next&gt;
        ///
        ///B2: 0002 - 0015: bne.un.s 0029 &lt;Cond_Branch&gt;
        ///	In : B1, B4
        ///	Out: B3, B4
        ///	0002: ldstr &quot;top&quot; &lt;Next&gt;
        ///	0007: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	0012: ldloc.0 &lt;Next&gt;
        ///	0013: ldc.i4.s 10 &lt;Next&gt;
        ///	0015: bne.un.s 0029 &lt;Cond_Branch&gt;
        ///
        ///B4: 0029 - 0043: br.s 0002 &lt;Branch&gt;
        ///	In : B2
        ///	Out: B2
        ///	0029: ldstr &quot;loop&quot; &lt;Next&gt;
        ///	0034: call [return: System.Void] System.Console::WriteLine() &lt;Call&gt;
        ///	0039: [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string WhileBreak {
            get {
                return ResourceManager.GetString("WhileBreak", resourceCulture);
            }
        }
    }
}