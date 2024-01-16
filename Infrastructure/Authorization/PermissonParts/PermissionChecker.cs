// -----------------------------------------------------------------------
// <copyright file="PermissionChecker.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq;

namespace WasWebServerCore.Infrastructure.Authorization.PermissonParts
{
    /// <summary>   A permission checker. </summary>
    public static class PermissionChecker
    {
        /// <summary>   A string extension method that this permission is allowed. </summary>
        /// <exception cref="InvalidEnumArgumentException"> Thrown when an Invalid Enum Argument error
        ///                                                 condition occurs. </exception>
        /// <param name="packedPermissions">    The packedPermissions to act on. </param>
        /// <param name="permissionName">       Name of the permission. </param>
        /// <returns>   True if it succeeds, false if it fails. </returns>
        public static bool ThisPermissionIsAllowed(this string packedPermissions, string permissionName)
        {
            var usersPermissions = PermissionPackers.UnpackPermissionsFromString(packedPermissions);

            if (!Enum.TryParse(permissionName, true, out Permissions permissionToCheck))
            {
                throw new InvalidEnumArgumentException($"{permissionName} could not be converted to a {nameof(Permissions)}.");
            }

            return usersPermissions.Contains(permissionToCheck);
        }
    }
}
