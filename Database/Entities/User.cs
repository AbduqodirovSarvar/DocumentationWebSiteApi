using DocumentationWebSiteApi.Database.Entities.Abstractions;
using DocumentationWebSiteApi.Database.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class User : AudiTable
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public Roles Role { get; set; } = default;
    }
}
