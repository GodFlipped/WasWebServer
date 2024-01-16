// -----------------------------------------------------------------------
// <copyright file="IIdentityService.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using WasWebServerCore.Infrastructure.Models;

namespace WasWebServerCore.Infrastructure.Services
{
    /// <summary>
    /// IIdentityService.
    /// </summary>
    public interface IIdentityService
    {
        /// <summary>
        /// Gets the user identity.
        /// </summary>
        /// <returns>userId.</returns>
        string GetUserIdentity();

        /// <summary>Gets the user identity.</summary>
        /// <returns>UserInformation object.</returns>
        UserInformation GetUserInformation();
    }
}
