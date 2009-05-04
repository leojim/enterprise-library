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
using Microsoft.Practices.Unity.InterceptionExtension;

namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Configuration
{
    /// <summary>
    /// Base class for configuration information stored about a call handler.
    /// </summary>
    public class CallHandlerData : NameTypeConfigurationElement
    {
        private const string orderProperty = "order";

        /// <summary>
        /// Creates a new instance of <see cref="CallHandlerData"/>.
        /// </summary>
        public CallHandlerData()
            : base()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="CallHandlerData"/>.
        /// </summary>
        /// <param name="handlerName">Name of handler entry.</param>
        /// <param name="handlerType">Type of handler to create.</param>
        public CallHandlerData(string handlerName, Type handlerType)
            : base(handlerName, handlerType)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="CallHandlerData"/>.
        /// </summary>
        /// <param name="handlerName">Name of handler entry.</param>
        /// <param name="handlerType">Type of handler to create.</param>
        /// <param name="order">The order of the handler.</param>
        public CallHandlerData(string handlerName, Type handlerType, int order)
            : base(handlerName, handlerType)
        {
            this.Order = order;
        }

        /// <summary>
        /// Gets or sets the Order in which the call handler will be executed
        /// </summary>
        [ConfigurationProperty(orderProperty, DefaultValue = 0, IsRequired = false)]
        public int Order
        {
            get { return (int)this[orderProperty]; }
            set { this[orderProperty] = value; }
        }

        /// <summary>
        /// Adds the call handler represented by this configuration object to <paramref name="policy"/>.
        /// </summary>
        /// <param name="policy">The policy to which the rule must be added.</param>
        /// <param name="configurationSource">The configuration source from which additional information
        /// can be retrieved, if necessary.</param>
        public virtual void ConfigurePolicy(PolicyDefinition policy, IConfigurationSource configurationSource)
        {
            throw new NotImplementedException();
        }
    }
}