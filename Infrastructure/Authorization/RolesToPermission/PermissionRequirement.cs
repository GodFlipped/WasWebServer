// -----------------------------------------------------------------------
// <copyright file="PermissionRequirement.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

using Microsoft.AspNetCore.Authorization;

namespace WasWebServerCore.Infrastructure.Authorization.RolesToPermission
{
    /// <summary>   A permission requirement. </summary>
    public class PermissionRequirement : IAuthorizationRequirement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionRequirement"/> class.   Constructor. </summary>
        /// <exception cref="ArgumentNullException">    Thrown when one or more required arguments are
        ///                                             null. </exception>
        /// <param name="permissionName">   The name of the permission. </param>
        public PermissionRequirement(string permissionName)
        {
            PermissionName = permissionName ?? throw new ArgumentNullException(nameof(permissionName));
        }

        /// <summary>   Gets the name of the permission. </summary>
        /// <value> The name of the permission. </value>
        public string PermissionName { get; }
    }
}
