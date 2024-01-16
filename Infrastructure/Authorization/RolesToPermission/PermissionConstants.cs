// -----------------------------------------------------------------------
// <copyright file="PermissionConstants.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace WasWebServerCore.Infrastructure.Authorization.RolesToPermission
{
    /// <summary>   A permission constants. </summary>
    public static class PermissionConstants
    {
        /// <summary>   Gets type of the packed permission claim. </summary>
        /// <value>
        ///    Type of the packed permission claim.
        /// </value>
        public static string PackedPermissionClaimType { get; } = "permissions";
    }
}
