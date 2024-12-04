using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class SubCategory : AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public ICollection<MultiLanguageText> Description { get; set; } = [];
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Topic> Topics { get; set; } = [];
    }
}
