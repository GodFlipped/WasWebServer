// -----------------------------------------------------------------------
// <copyright file="PermissionPackers.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WasWebServerCore.Infrastructure.Authorization.PermissonParts
{
    /// <summary>   A permission packers. </summary>
    public static class PermissionPackers
    {
        /// <summary>   Type of the pack. </summary>
        public static readonly char PackType = 'H';

        /// <summary>   Size of the packed. </summary>
        public static readonly int PackedSize = 6;

        /// <summary>   Form default pack prefix. </summary>
        /// <returns>   A string. </returns>
        public static string FormDefaultPackPrefix()
        {
            return $"{PackType}{PackedSize:D1}-";
        }

        /// <summary>
        /// An IEnumerable&lt;Permissions&gt; extension method that pack permissions into string.
        /// </summary>
        /// <param name="permissions">  The permissions to act on. </param>
        /// <returns>   A string. </returns>
        public static string PackPermissionsIntoString(this IEnumerable<Permissions> permissions)
        {
            return permissions.Aggregate(FormDefaultPackPrefix(), (s, permission) => s + ((int)permission).ToString("X4"));
        }

        /// <summary>   Enumerates unpack permission values from string in this collection. </summary>
        /// <param name="packedPermissions">    The packedPermissions to act on. </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process unpack permission values from string
        /// in this collection.
        /// </returns>
        public static IEnumerable<int> UnpackPermissionValuesFromString(this string packedPermissions)
        {
            var packPrefix = CheckPackedPermissions(packedPermissions);

            int index = packPrefix.Length;
            while (index < packedPermissions.Length)
            {
                yield return int.Parse(packedPermissions.Substring(index, PackedSize), NumberStyles.HexNumber);
                index += PackedSize;
            }
        }

        /// <summary>   Check packed permissions. </summary>
        /// <exception cref="ArgumentNullException">        Thrown when one or more required arguments
        ///                                                 are null. </exception>
        /// <exception cref="InvalidOperationException">    Thrown when the requested operation is
        ///                                                 invalid. </exception>
        /// <param name="packedPermissions">    The packedPermissions to act on. </param>
        /// <returns>   A string. </returns>
        public static string CheckPackedPermissions(string packedPermissions)
        {
            var packPrefix = FormDefaultPackPrefix();
            if (packedPermissions == null)
            {
                throw new ArgumentNullException(nameof(packedPermissions));
            }

            if (!packedPermissions.StartsWith(packPrefix))
            {
                throw new InvalidOperationException("The format of the packed permissions is wrong" +
                                                    $" - should start with {packPrefix}");
            }

            return packPrefix;
        }

        /// <summary>   Enumerates unpack permissions from string in this collection. </summary>
        /// <param name="packedPermissions">    The packedPermissions to act on. </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process unpack permissions from string in
        /// this collection.
        /// </returns>
        public static IEnumerable<Permissions> UnpackPermissionsFromString(this string packedPermissions)
        {
            return packedPermissions.UnpackPermissionValuesFromString().Select(x => (Permissions)x);
        }

        /// <summary>
        /// A string extension method that searches for the first permission via name.
        /// </summary>
        /// <param name="permissionName">   The permissionName to act on. </param>
        /// <returns>   The found permission via name. </returns>
        public static Permissions? FindPermissionViaName(this string permissionName)
        {
            return Enum.TryParse(permissionName, out Permissions permission)
                ? (Permissions?)permission
                : null;
        }
    }
}
