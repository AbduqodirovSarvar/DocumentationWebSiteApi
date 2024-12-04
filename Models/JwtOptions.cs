namespace DocumentationWebSiteApi.Models
{
    public sealed class JwtOptions
    {
        public string ValidIssuer { get; set; } = null!;
        public string ValidAudience { get; set; } = null!;
        public string SecretKey { get; set; } = null!;
    }
}
