using DocumentationWebSiteApi.Database.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class SubCategory : AudiTable
    {
        [NotMapped]
        public IEnumerable<MultiLanguageText> Name => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Name);
        [NotMapped]
        public IEnumerable<MultiLanguageText> Description => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Description);
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Topic> Topics { get; set; } = [];
    }
}
