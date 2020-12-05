using System.Collections.Generic;
using IdentityServer4.Models;

namespace BookStore.Identity
{
    public static class ApiConfig
    {
        public static IEnumerable<Client> GetAllClient
            => new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha512())
                    },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = new List<string>{ "bookStoreAPI" }
                }
            };

        public static IEnumerable<ApiResource> GetAllApiResource
            => new List<ApiResource>
            {
                new ApiResource("bookStoreAPI")
            };

        public static IEnumerable<ApiScope> GetAllScope
            => new List<ApiScope>
            {
                new ApiScope("bookStoreAPI")
            };
    }
}