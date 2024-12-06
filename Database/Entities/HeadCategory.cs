using DocumentationWebSiteApi.Database.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class HeadCategory: AudiTable
    {
        [NotMapped]
        public IEnumerable<MultiLanguageText> Name => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Name);
        [NotMapped]
        public IEnumerable<MultiLanguageText> Description => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Description);
        public ICollection<Category> Categories { get; set; } = [];
    }
}
