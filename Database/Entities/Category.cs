using DocumentationWebSiteApi.Database.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Category : AudiTable
    {
        [NotMapped]
        public IEnumerable<MultiLanguageText> Name => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Name);
        [NotMapped]
        public IEnumerable<MultiLanguageText> Description => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Description);
        public Guid HeadCategoryId { get; set; }
        public HeadCategory? HeadCategory { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; } = [];
    }
}
