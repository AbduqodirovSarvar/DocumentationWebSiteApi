using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Category : AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public ICollection<MultiLanguageText> Description { get; set; } = [];
        public Guid HeadCategoryId { get; set; }
        public HeadCategory? HeadCategory { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; } = [];
    }
}
