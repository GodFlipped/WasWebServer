// -----------------------------------------------------------------------
// <copyright file="IdentityService.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

using WasWebServerCore.Infrastructure.Models;
using Microsoft.AspNetCore.Http;

namespace WasWebServerCore.Infrastructure.Services
{
    /// <summary>
    /// IdentityService.
    /// </summary>
    /// <seealso cref="IIdentityService" />
    public class IdentityService : IIdentityService
    {
        /// <summary>
        /// The context.
        /// </summary>
        private readonly IHttpContextAccessor context;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityService"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <exception cref="ArgumentNullException">context.</exception>
        public IdentityService(IHttpContextAccessor context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Gets the user identity.
        /// </summary>
        /// <returns>
        /// userId.
        /// </returns>
        public string GetUserIdentity() => context.HttpContext.User.FindFirst(JwtRegisteredClaimNames.Sub).Value;

        /// <summary>
        /// Gets the user information.
        /// </summary>
        /// <returns>
        /// UserInformation Object.
        /// </returns>
        public UserInformation GetUserInformation()
        {
            var userInformation = new UserInformation
            {
                UserId = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value,
                UserEmail = context.HttpContext.User.FindFirst(ClaimTypes.Email).Value,
                UserName = context.HttpContext.User.FindFirst(ClaimTypes.Name).Value,
                UserPhone = context.HttpContext.User.FindFirst("phone_number").Value,
            };

            return userInformation;
        }
    }
}
