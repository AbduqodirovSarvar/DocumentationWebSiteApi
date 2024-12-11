using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Models;
using DocumentationWebSiteApi.Services.Abstractions.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DocumentationWebSiteApi.Services
{
    public class TokenService(
        IOptions<JwtOptions> config
        ) : ITokenService
    {
        private readonly JwtOptions _configuration = config.Value
                ?? throw new ArgumentNullException(nameof(config), "JwtOptions cannot be null.");

        public string GetToken(User user)
        {
            Claim[] jwtClaim =
            [
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Name, DateTime.UtcNow.ToString()),
                new Claim("Roles", user.Role.ToString()),
            ];

            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.SecretKey)),
                SecurityAlgorithms.HmacSha256
            );
           
            var token = new JwtSecurityToken(
                _configuration.ValidIssuer,
                _configuration.ValidAudience,
               jwtClaim,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: credentials);

            var tokenHandler = new JwtSecurityTokenHandler();

            return tokenHandler.WriteToken(token);
        }
    }
}
