using Duende.IdentityServer.Models;

namespace IdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
        {
            new ApiScope(name:"api1", displayName:"MyApi"),
            new ApiScope(name:"profile")
        };

    public static IEnumerable<Client> Clients =>
        new List<Client>
        {
            new Client()
            {
                ClientId= "1",
                AllowedGrantTypes=GrantTypes.Code,
                AllowedScopes={"api1","openid","profile"},

                AllowedCorsOrigins={ "https://localhost:7247" },
                RedirectUris={ "https://localhost:7247/authentication/login-callback" },
                RequireClientSecret=false,
                AllowOfflineAccess=true,
                RefreshTokenUsage=TokenUsage.OneTimeOnly,
                RefreshTokenExpiration=TokenExpiration.Sliding
            }
        };
}