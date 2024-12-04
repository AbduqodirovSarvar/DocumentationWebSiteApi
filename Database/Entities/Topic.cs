using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Topic: AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public ICollection<MultiLanguageText> Description { get; set; } = [];
        public Guid SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public ICollection<Content> Contents { get; set; } = [];
    }
}
