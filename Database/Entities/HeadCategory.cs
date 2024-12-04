using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class HeadCategory: AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public ICollection<MultiLanguageText> Description { get; set; } = [];
        public ICollection<Category> Categories { get; set; } = [];
    }
}
