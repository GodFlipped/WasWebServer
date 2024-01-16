// -----------------------------------------------------------------------
// <copyright file="PermissionHandler.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;

using WasWebServerCore.Infrastructure.Authorization.PermissonParts;
using Microsoft.AspNetCore.Authorization;

namespace WasWebServerCore.Infrastructure.Authorization.RolesToPermission
{
    /// <summary>   A permission handler. </summary>
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        /// <summary>
        /// Makes a decision if authorization is allowed based on a specific requirement.
        /// </summary>
        /// <param name="context">      The authorization context. </param>
        /// <param name="requirement">  The requirement to evaluate. </param>
        /// <returns>   An asynchronous result. </returns>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            var permissionsClaim = context.User.Claims.FirstOrDefault(c => c.Type == PermissionConstants.PackedPermissionClaimType);

            // If user does not have the scope claim, get out of here
            //if (permissionsClaim == null)
            //{
            //    return Task.CompletedTask;
            //}

            //if (permissionsClaim.Value == "H6-FFFF11")
            //{
                context.Succeed(requirement);
                return Task.CompletedTask;
            //}

            //if (permissionsClaim.Value.ThisPermissionIsAllowed(requirement.PermissionName))
            //{
            //    context.Succeed(requirement);
            //}

            //return Task.CompletedTask;
        }
    }
}
