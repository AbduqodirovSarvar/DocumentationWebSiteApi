using DocumentationWebSiteApi.Database.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Topic: AudiTable
    {
        [NotMapped]
        public IEnumerable<MultiLanguageText> Name => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Name);
        [NotMapped]
        public IEnumerable<MultiLanguageText> Description => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Description);
        public Guid SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public ICollection<Content> Contents { get; set; } = [];
    }
}
