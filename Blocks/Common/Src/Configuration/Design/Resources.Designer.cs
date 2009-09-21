﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
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
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to General.
        /// </summary>
        internal static string CategoryGeneral {
            get {
                return ResourceManager.GetString("CategoryGeneral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Localization.
        /// </summary>
        internal static string CategoryLocalization {
            get {
                return ResourceManager.GetString("CategoryLocalization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (name).
        /// </summary>
        internal static string CategoryName {
            get {
                return ResourceManager.GetString("CategoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration Sources.
        /// </summary>
        internal static string ConfigurationSourceSectionDisplayName {
            get {
                return ResourceManager.GetString("ConfigurationSourceSectionDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string ConfigurationSourceSectionParentSourceDescription {
            get {
                return ResourceManager.GetString("ConfigurationSourceSectionParentSourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parent Source.
        /// </summary>
        internal static string ConfigurationSourceSectionParentSourceDisplayName {
            get {
                return ResourceManager.GetString("ConfigurationSourceSectionParentSourceDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Redirected Sections.
        /// </summary>
        internal static string ConfigurationSourceSectionRedirectedSectionsDisplayName {
            get {
                return ResourceManager.GetString("ConfigurationSourceSectionRedirectedSectionsDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string ConfigurationSourceSectionSelectedSourceDescription {
            get {
                return ResourceManager.GetString("ConfigurationSourceSectionSelectedSourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected Source.
        /// </summary>
        internal static string ConfigurationSourceSectionSelectedSourceDisplayName {
            get {
                return ResourceManager.GetString("ConfigurationSourceSectionSelectedSourceDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sources.
        /// </summary>
        internal static string ConfigurationSourceSectionSourcesDisplayName {
            get {
                return ResourceManager.GetString("ConfigurationSourceSectionSourcesDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be null or string or empty..
        /// </summary>
        internal static string ExceptionStringNullOrEmpty {
            get {
                return ResourceManager.GetString("ExceptionStringNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for {0} can not be null..
        /// </summary>
        internal static string ExceptionValueNullMessage {
            get {
                return ResourceManager.GetString("ExceptionValueNullMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string FileConfigurationSourceElementDescription {
            get {
                return ResourceManager.GetString("FileConfigurationSourceElementDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File Based Configuration Source.
        /// </summary>
        internal static string FileConfigurationSourceElementDisplayName {
            get {
                return ResourceManager.GetString("FileConfigurationSourceElementDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string FileConfigurationSourceElementFilePathDescription {
            get {
                return ResourceManager.GetString("FileConfigurationSourceElementFilePathDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File Path.
        /// </summary>
        internal static string FileConfigurationSourceElementFilePathDisplayName {
            get {
                return ResourceManager.GetString("FileConfigurationSourceElementFilePathDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration Files (*.config)|*.config|All files (*.*)|*.*.
        /// </summary>
        internal static string FileConfigurationSourceElementFilePathFilter {
            get {
                return ResourceManager.GetString("FileConfigurationSourceElementFilePathFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instrumentation Settings.
        /// </summary>
        internal static string InstrumentationSectionDisplayName {
            get {
                return ResourceManager.GetString("InstrumentationSectionDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InstrumentationSectionEventLoggingEnabledDescription.
        /// </summary>
        internal static string InstrumentationSectionEventLoggingEnabledDescription {
            get {
                return ResourceManager.GetString("InstrumentationSectionEventLoggingEnabledDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Event Log.
        /// </summary>
        internal static string InstrumentationSectionEventLoggingEnabledDisplayName {
            get {
                return ResourceManager.GetString("InstrumentationSectionEventLoggingEnabledDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InstrumentationSectionPerformanceCountersEnabledDescription.
        /// </summary>
        internal static string InstrumentationSectionPerformanceCountersEnabledDescription {
            get {
                return ResourceManager.GetString("InstrumentationSectionPerformanceCountersEnabledDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Performance Counters.
        /// </summary>
        internal static string InstrumentationSectionPerformanceCountersEnabledDisplayName {
            get {
                return ResourceManager.GetString("InstrumentationSectionPerformanceCountersEnabledDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InstrumentationSectionWmiEnabledDescription.
        /// </summary>
        internal static string InstrumentationSectionWmiEnabledDescription {
            get {
                return ResourceManager.GetString("InstrumentationSectionWmiEnabledDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable WMI.
        /// </summary>
        internal static string InstrumentationSectionWmiEnabledDisplayName {
            get {
                return ResourceManager.GetString("InstrumentationSectionWmiEnabledDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string ManageableConfigurationSourceElementApplicationNameDescription {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementApplicationNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Application Name.
        /// </summary>
        internal static string ManageableConfigurationSourceElementApplicationNameDisplayName {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementApplicationNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string ManageableConfigurationSourceElementDescription {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manageable Configuration Source.
        /// </summary>
        internal static string ManageableConfigurationSourceElementDisplayName {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string ManageableConfigurationSourceElementEnableGroupPoliciesDescription {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementEnableGroupPoliciesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Group Policy Enabled.
        /// </summary>
        internal static string ManageableConfigurationSourceElementEnableGroupPoliciesDisplayName {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementEnableGroupPoliciesDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string ManageableConfigurationSourceElementEnableWmiDescription {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementEnableWmiDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WMI Enabled.
        /// </summary>
        internal static string ManageableConfigurationSourceElementEnableWmiDisplayName {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementEnableWmiDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string ManageableConfigurationSourceElementFilePathDescription {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementFilePathDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File Path.
        /// </summary>
        internal static string ManageableConfigurationSourceElementFilePathDisplayName {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementFilePathDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All files (*.*)|*.*.
        /// </summary>
        internal static string ManageableConfigurationSourceElementFilePathFilter {
            get {
                return ResourceManager.GetString("ManageableConfigurationSourceElementFilePathFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        internal static string NameDisplayName {
            get {
                return ResourceManager.GetString("NameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string RedirectedSectionElementDescription {
            get {
                return ResourceManager.GetString("RedirectedSectionElementDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Redirected Sections.
        /// </summary>
        internal static string RedirectedSectionElementDisplayName {
            get {
                return ResourceManager.GetString("RedirectedSectionElementDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string RedirectedSectionElementSourceNameDescription {
            get {
                return ResourceManager.GetString("RedirectedSectionElementSourceNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source.
        /// </summary>
        internal static string RedirectedSectionElementSourceNameDisplayName {
            get {
                return ResourceManager.GetString("RedirectedSectionElementSourceNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string SystemConfigurationSourceElementDescription {
            get {
                return ResourceManager.GetString("SystemConfigurationSourceElementDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System Configuration Source.
        /// </summary>
        internal static string SystemConfigurationSourceElementDisplayName {
            get {
                return ResourceManager.GetString("SystemConfigurationSourceElementDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type.
        /// </summary>
        internal static string TypeNameDisplayName {
            get {
                return ResourceManager.GetString("TypeNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} is invalid for {1}. Message: {2}.
        /// </summary>
        internal static string ValidationErrorToString {
            get {
                return ResourceManager.GetString("ValidationErrorToString", resourceCulture);
            }
        }
    }
}