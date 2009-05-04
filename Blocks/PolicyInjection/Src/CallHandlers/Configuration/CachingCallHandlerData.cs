﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Policy Injection Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.CallHandlers.Configuration
{
    /// <summary>
    /// Configuration element class that manages the config data for the <see cref="CachingCallHandler"/>.
    /// </summary>
    public class CachingCallHandlerData : CallHandlerData
    {
        private const string ExpirationTimePropertyName = "expirationTime";

        /// <summary>
        /// Create a new <see cref="CachingCallHandlerData"/> instance.
        /// </summary>
        public CachingCallHandlerData()
        {
            ExpirationTime = CachingCallHandler.DefaultExpirationTime;
        }

        /// <summary>
        /// Create a new <see cref="CachingCallHandlerData"/> instance with the given name.
        /// </summary>
        /// <param name="handlerName">Name of handler to store in config file.</param>
        public CachingCallHandlerData(string handlerName)
            : base(handlerName, typeof(CachingCallHandler))
        {
            ExpirationTime = CachingCallHandler.DefaultExpirationTime;
        }

        /// <summary>
        /// Create a new <see cref="CachingCallHandlerData"/> instance with the given name.
        /// </summary>
        /// <param name="handlerName">Name of handler to store in config file.</param>
        /// <param name="handlerOrder">Order of handler to store in config file.</param>
        public CachingCallHandlerData(string handlerName, int handlerOrder)
            : base(handlerName, typeof(CachingCallHandler), handlerOrder)
        {
            ExpirationTime = CachingCallHandler.DefaultExpirationTime;
        }

        /// <summary>
        /// Expiration time
        /// </summary>
        /// <value>The "expirationTime" attribute</value>
        [ConfigurationProperty(ExpirationTimePropertyName)]
        public TimeSpan ExpirationTime
        {
            get { return (TimeSpan)base[ExpirationTimePropertyName]; }
            set { base[ExpirationTimePropertyName] = value; }
        }

        /// <summary>
        /// Adds the call handler represented by this configuration object to <paramref name="policy"/>.
        /// </summary>
        /// <param name="policy">The policy to which the rule must be added.</param>
        /// <param name="configurationSource">The configuration source from which additional information
        /// can be retrieved, if necessary.</param>
        public override void ConfigurePolicy(PolicyDefinition policy, IConfigurationSource configurationSource)
        {
            policy.AddCallHandler<CachingCallHandler>(
                new ContainerControlledLifetimeManager(),
                new InjectionConstructor(
                    new InjectionParameter<TimeSpan>(this.ExpirationTime),
                    new InjectionParameter<int>(this.Order)));
        }
    }
}