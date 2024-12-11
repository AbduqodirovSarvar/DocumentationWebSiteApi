using DocumentationWebSiteApi.Database.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace DocumentationWebSiteApi.Requests.Auth
{
    public class CreateUserRequest
    {
        public string Firstname { get; set; } = default!;
        public string Lastname { get; set; } = default!;
        [EmailAddress]
        public string Email { get; set; } = default!;
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public Roles Role { get; set; }

    }
}
