using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.OAuth.Configuration
{
    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[]
            {
                new ApiResource("SSO.Web","SSO.Web")
            };
        }

        public static IEnumerable<IdentityResource> IdentityResources()
        {
            return new IdentityResource[] {
                    new IdentityResources.OpenId(),
                    new IdentityResources.Profile()
            };
        }

        public static IEnumerable<Client> Clients()
        {
            return new[]
            {
                new Client
                {
                    ClientId = "SSO.Implicit",
                    ClientSecrets = new [] {new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new [] {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "SSO.Web" },
                    AllowAccessTokensViaBrowser = true,
                    RedirectUris = new [] { "http://localhost:54615/signin-oidc" },
                    PostLogoutRedirectUris = { "http://localhost:54615/signout-callback-oidc" },
                    RequireConsent = false,
                    ClientName = "SSO.Web"
                }
            };
        }
    }
}
