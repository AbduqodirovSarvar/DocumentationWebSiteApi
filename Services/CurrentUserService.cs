using DocumentationWebSiteApi.Services.Abstractions.Interfaces;
using System.Security.Claims;

namespace DocumentationWebSiteApi.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public Guid Id { get; set; }

        public CurrentUserService(IHttpContextAccessor _contextAccessor)
        {
            var httpContext = _contextAccessor.HttpContext;
            var userClaims = httpContext?.User.Claims;
            var idClaim = userClaims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            if (idClaim != null && Guid.TryParse(idClaim.Value, out Guid value))
            {
                Id = value;
            }
        }
    }
}
