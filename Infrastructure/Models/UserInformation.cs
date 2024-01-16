// -----------------------------------------------------------------------
// <copyright file="UserInformation.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace WasWebServerCore.Infrastructure.Models
{
    /// <summary>
    /// user information from token.
    /// </summary>
    public class UserInformation
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user email.
        /// </summary>
        /// <value>
        /// The user email.
        /// </value>
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the user phone.
        /// </summary>
        /// <value>
        /// The user phone.
        /// </value>
        public string UserPhone { get; set; }
    }
}
