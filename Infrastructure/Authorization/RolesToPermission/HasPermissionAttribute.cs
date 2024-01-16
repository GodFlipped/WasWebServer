// -----------------------------------------------------------------------
// <copyright file="HasPermissionAttribute.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

using WasWebServerCore.Infrastructure.Authorization.PermissonParts;
using Microsoft.AspNetCore.Authorization;

namespace WasWebServerCore.Infrastructure.Authorization.RolesToPermission
{
    /// <summary>   Attribute for has permission. </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false)]
    public sealed class HasPermissionAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasPermissionAttribute"/> class.   Constructor. </summary>
        /// <param name="permission">   The permission. </param>
        public HasPermissionAttribute(Permissions permission)
            : base(permission.ToString())
        {
        }
    }
}
