// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using IdentityModel;
using System.Collections.Generic;

namespace Chocolate.Idp
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Address(),
                new IdentityResource("roles", "Your role(s)", new List<string>() { "role" })
            };

        public static IEnumerable<ApiScope> ApiScopes =>
          new ApiScope[]
          { 
              new ApiScope("chocolateapi",
                    "Chocolate Api",
                    new List<string>() { "role" })
          };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource(
                    "chocolateapi",
                    "Chocolate Api",
                    new List<string>() { "role" })
                {
                    ApiSecrets = { new Secret("oleksecret".Sha256()) },
                    Scopes = new List<string>() 
                    {
                        "chocolateapi"
                    }
                }
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    AccessTokenType = AccessTokenType.Jwt,
                    AllowOfflineAccess = true,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    RequirePkce = true,
                    ClientName= "Choco Web Face",
                    ClientId = "chocowebface",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireConsent = true,
                    RedirectUris = new List<string>
                    {
                        "https://localhost:44349/signin-oidc"
                    },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Address,
                        "roles",
                        "chocolateapi"
                    },
                    ClientSecrets = new []
                    {
                        new Secret("oleksecret".Sha256())
                    }
                }
            };
    }
}