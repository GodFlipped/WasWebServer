// -----------------------------------------------------------------------
// <copyright file="PermissionDisplay.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace WasWebServerCore.Infrastructure.Authorization.PermissonParts
{
    /// <summary>   A permission display. </summary>
    public class PermissionDisplay
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionDisplay"/> class.   Constructor. </summary>
        /// <exception cref="ArgumentNullException">    Thrown when one or more required arguments are
        ///                                             null. </exception>
        /// <param name="groupName">    The name of the group. </param>
        /// <param name="name">         The name. </param>
        /// <param name="description">  The description. </param>
        /// <param name="permission">   The permission. </param>
        /// <param name="moduleName">   The name of the module. </param>
        public PermissionDisplay(string groupName, string name, string description, Permissions permission, string moduleName)
        {
            Permission = permission;
            GroupName = groupName;
            ShortName = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            ModuleName = moduleName;
        }

        /// <summary>   Gets groupName, which groups permissions working in the same area. </summary>
        /// <value> The name of the group. </value>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets shortName of the permission - often says what it does, e.g. Read.
        /// </summary>
        /// <value> The name of the short. </value>
        public string ShortName { get; private set; }

        /// <summary>   Gets long description of what action this permission allows. </summary>
        /// <value> The description. </value>
        public string Description { get; private set; }

        /// <summary>   Gets gives the actual permission. </summary>
        /// <value> The permission. </value>
        public Permissions Permission { get; private set; }

        /// <summary>
        /// Gets contains an optional paidForModule that this feature is linked to.
        /// </summary>
        /// <value> The name of the module. </value>
        public string ModuleName { get; private set; }

        /// <summary>
        /// GetPermissionsToDisplay is used to display permission detail infos on Admin UI.
        /// </summary>
        /// <param name="enumType"> permission enumeration. </param>
        /// <returns>   The detailed information of permissions. </returns>
        public static IEnumerable<PermissionDisplay> GetPermissionsToDisplay(Type enumType)
        {
            var result = new List<PermissionDisplay>();
            foreach (var permissionName in Enum.GetNames(enumType))
            {
                var member = enumType.GetMember(permissionName);

                // This allows you to obsolete a permission and it won't be shown as a possible option, but is still there so you won't reuse the number
                var obsoleteAttribute = member[0].GetCustomAttribute<ObsoleteAttribute>();
                if (obsoleteAttribute != null)
                {
                    continue;
                }

                // If there is no DisplayAttribute then the Enum is not used
                var displayAttribute = member[0].GetCustomAttribute<DisplayAttribute>();
                if (displayAttribute == null)
                {
                    continue;
                }

                // Gets the optional PaidForModule that a permission can be linked to
                var moduleAttribute = member[0].GetCustomAttribute<LinkedToModuleAttribute>();

                var permission = (Permissions)Enum.Parse(enumType, permissionName, false);

                result.Add(new PermissionDisplay(displayAttribute.GroupName, displayAttribute.Name, displayAttribute.Description, permission, moduleAttribute?.PaidForModule.ToString()));
            }

            return result;
        }
    }
}
