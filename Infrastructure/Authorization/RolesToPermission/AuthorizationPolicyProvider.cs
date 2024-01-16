// -----------------------------------------------------------------------
// <copyright file="AuthorizationPolicyProvider.cs" company="Kengic">
// Copyright (c) Kengic. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;

namespace WasWebServerCore.Infrastructure.Authorization.RolesToPermission
{
    /// <summary>   An authorization policy provider. </summary>
    public class AuthorizationPolicyProvider : DefaultAuthorizationPolicyProvider
    {
        /// <summary>   Options for controlling the operation. </summary>
        private readonly AuthorizationOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationPolicyProvider"/> class.   Constructor. </summary>
        /// <param name="options">  Options for controlling the operation. </param>
        public AuthorizationPolicyProvider(IOptions<AuthorizationOptions> options)
            : base(options)
        {
            this.options = options.Value;
        }

        /// <summary>
        /// Gets a <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> from the given.
        /// </summary>
        /// <param name="policyName">   The policy name to retrieve. </param>
        /// <returns>
        /// The named <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" />.
        /// </returns>
        public override async Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            var policy = await base.GetPolicyAsync(policyName);

            if (policy == null)
            {
                policy = new AuthorizationPolicyBuilder()
                    .AddRequirements(new PermissionRequirement(policyName))
                    .Build();
            }

            return policy;
        }
    }
}
