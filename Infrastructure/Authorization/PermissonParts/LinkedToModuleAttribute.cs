// -----------------------------------------------------------------------
// <copyright file="LinkedToModuleAttribute.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace WasWebServerCore.Infrastructure.Authorization.PermissonParts
{
    /// <summary>   Attribute for linked to module. </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public sealed class LinkedToModuleAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedToModuleAttribute"/> class.   Constructor. </summary>
        /// <param name="paidForModule">    The paid for module. </param>
        public LinkedToModuleAttribute(PaidForModules paidForModule)
        {
            PaidForModule = paidForModule;
        }

        /// <summary>   Gets the paid for module. </summary>
        /// <value> The paid for module. </value>
        public PaidForModules PaidForModule { get; private set; }
    }
}
