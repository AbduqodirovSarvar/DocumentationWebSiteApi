using System.Security.Claims;

namespace DocumentationWebSiteApi.Services.Abstractions.Interfaces
{
    public interface ITokenService
    {
        string GetToken(Claim[] claims);
    }
}
