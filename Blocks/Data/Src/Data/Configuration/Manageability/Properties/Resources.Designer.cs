﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Data Access Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Manageability.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Data.Configuration.Manageability.Properties" +
                            ".Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Connection string.
        /// </summary>
        internal static string ConnectionStringConnectionStringPartName {
            get {
                return ResourceManager.GetString("ConnectionStringConnectionStringPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify settings for connection &apos;{0}&apos;.
        /// </summary>
        internal static string ConnectionStringPolicyNameTemplate {
            get {
                return ResourceManager.GetString("ConnectionStringPolicyNameTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider name.
        /// </summary>
        internal static string ConnectionStringProviderNamePartName {
            get {
                return ResourceManager.GetString("ConnectionStringProviderNamePartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection strings.
        /// </summary>
        internal static string ConnectionStringsCategoryName {
            get {
                return ResourceManager.GetString("ConnectionStringsCategoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database.
        /// </summary>
        internal static string DatabaseCategoryName {
            get {
                return ResourceManager.GetString("DatabaseCategoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default database.
        /// </summary>
        internal static string DatabaseSettingsDefaultDatabasePartName {
            get {
                return ResourceManager.GetString("DatabaseSettingsDefaultDatabasePartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify Database Block Settings.
        /// </summary>
        internal static string DatabaseSettingsPolicyName {
            get {
                return ResourceManager.GetString("DatabaseSettingsPolicyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package mappings.
        /// </summary>
        internal static string OracleConnectionPackagesPartName {
            get {
                return ResourceManager.GetString("OracleConnectionPackagesPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify settings for oracle connection &apos;{0}&apos;.
        /// </summary>
        internal static string OracleConnectionPolicyNameTemplate {
            get {
                return ResourceManager.GetString("OracleConnectionPolicyNameTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oracle packages.
        /// </summary>
        internal static string OracleConnectionsCategoryName {
            get {
                return ResourceManager.GetString("OracleConnectionsCategoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database type.
        /// </summary>
        internal static string ProviderMappingDatabaseTypePartName {
            get {
                return ResourceManager.GetString("ProviderMappingDatabaseTypePartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify settings for provider &apos;{0}&apos;.
        /// </summary>
        internal static string ProviderMappingPolicyNameTemplate {
            get {
                return ResourceManager.GetString("ProviderMappingPolicyNameTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider mappings.
        /// </summary>
        internal static string ProviderMappingsCategoryName {
            get {
                return ResourceManager.GetString("ProviderMappingsCategoryName", resourceCulture);
            }
        }
    }
}