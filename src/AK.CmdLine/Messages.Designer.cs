﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AK.CmdLine {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AK.CmdLine.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to A duplicate method named &apos;{0}&apos; is declared by type &apos;{1}&apos;. Note that method names and short names are treated case insensitively and overloads are not supported; use default values instead..
        /// </summary>
        internal static string ComponentDescriptor_DuplicateMethod {
            get {
                return ResourceManager.GetString("ComponentDescriptor_DuplicateMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to usage: a command name is required.
        /// </summary>
        internal static string DefaultUsageWriter_CommandRequired {
            get {
                return ResourceManager.GetString("DefaultUsageWriter_CommandRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to usage: unrecognised argument &apos;{0}&apos; for &apos;{1}&apos; command.
        /// </summary>
        internal static string DefaultUsageWriter_InvalidArgumentName {
            get {
                return ResourceManager.GetString("DefaultUsageWriter_InvalidArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to usage: unable to convert &apos;{1}&apos; to &apos;{2}&apos; expected by &apos;{0}&apos;.
        /// </summary>
        internal static string DefaultUsageWriter_InvalidArgumentValue {
            get {
                return ResourceManager.GetString("DefaultUsageWriter_InvalidArgumentValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to usage: unrecognised command name &apos;{0}&apos;.
        /// </summary>
        internal static string DefaultUsageWriter_InvalidCommand {
            get {
                return ResourceManager.GetString("DefaultUsageWriter_InvalidCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to usage: invalid number of arguments provided for &apos;{0}&apos; command.
        /// </summary>
        internal static string DefaultUsageWriter_InvalidNumberOfArguments {
            get {
                return ResourceManager.GetString("DefaultUsageWriter_InvalidNumberOfArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to usage: unrecognised switch format &apos;{0}&apos;.
        /// </summary>
        internal static string DefaultUsageWriter_InvalidSwitchFormat {
            get {
                return ResourceManager.GetString("DefaultUsageWriter_InvalidSwitchFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected non-empty collection..
        /// </summary>
        internal static string Guard_NonEmptyCollection {
            get {
                return ResourceManager.GetString("Guard_NonEmptyCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected non-empty String..
        /// </summary>
        internal static string Guard_NonEmptyString {
            get {
                return ResourceManager.GetString("Guard_NonEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A duplicate parameter named &apos;{0}&apos; is declared in the signature method &apos;{1}&apos; declared by type &apos;{2}&apos;. Note that parameter names and short names are treated case insensitively..
        /// </summary>
        internal static string MethodDescriptor_DuplicateParameter {
            get {
                return ResourceManager.GetString("MethodDescriptor_DuplicateParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An array type parameter named &apos;{0}&apos; is declared in the signature method &apos;{1}&apos; declared by type &apos;{2}&apos;. Note that only array type parameters decorated with param array attribute are supported..
        /// </summary>
        internal static string ParameterDescriptor_OnlyParamArraysAreSupported {
            get {
                return ResourceManager.GetString("ParameterDescriptor_OnlyParamArraysAreSupported", resourceCulture);
            }
        }
    }
}
