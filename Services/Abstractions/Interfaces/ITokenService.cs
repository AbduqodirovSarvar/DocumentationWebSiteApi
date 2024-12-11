using DocumentationWebSiteApi.Database.Entities;
using System.Security.Claims;

namespace DocumentationWebSiteApi.Services.Abstractions.Interfaces
{
    public interface ITokenService
    {
        string GetToken(User user);
    }
}
