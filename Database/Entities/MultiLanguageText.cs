using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class MultiLanguageText : AudiTable
    {
        public Guid LanguageId { get; set; }
        public Language? Language { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
