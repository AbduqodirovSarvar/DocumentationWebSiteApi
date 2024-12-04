using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Contact : AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public string? Icon { get; set; }
        public Guid AboutUsId { get; set; }
        public AboutUs? AboutUs { get; set; }
    }
}
