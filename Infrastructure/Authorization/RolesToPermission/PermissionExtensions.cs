// -----------------------------------------------------------------------
// <copyright file="PermissionExtensions.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Linq;
using System.Security.Claims;

using WasWebServerCore.Infrastructure.Authorization.PermissonParts;

namespace WasWebServerCore.Infrastructure.Authorization.RolesToPermission
{
    /// <summary>   A permission extensions. </summary>
    public static class PermissionExtensions
    {
        /// <summary>   This returns true if the current user has the permission. </summary>
        /// <param name="user">         user. </param>
        /// <param name="permission">   permission. </param>
        /// <returns>   bool. </returns>
        public static bool UserHasThisPermission(this ClaimsPrincipal user, Permissions permission)
        {
            var permissionClaim =
                user?.Claims.SingleOrDefault(x => x.Type == PermissionConstants.PackedPermissionClaimType);
            return permissionClaim?.Value.UnpackPermissionsFromString().Contains(permission) == true;
        }
    }
}
