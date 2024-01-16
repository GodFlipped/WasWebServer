// -----------------------------------------------------------------------
// <copyright file="PaidForModules.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace WasWebServerCore.Infrastructure.Authorization.PermissonParts
{
    /// <summary>
    /// This is an example of how you would manage what optional parts of your system a user can
    /// access NOTE: You can add Display attributes (as done on Permissions) to give more information
    /// about a module.
    /// </summary>
    [Flags]
    public enum PaidForModules
    {
        /// <summary>   A binary constant representing the none flag. </summary>
        None = 0,

        /// <summary>
        /// The feature1
        /// </summary>
        Feature1 = 1,

        /// <summary>
        /// The feature2
        /// </summary>
        Feature2 = 2,

        /// <summary>
        /// The feature3
        /// </summary>
        Feature3 = 4,
    }
}
