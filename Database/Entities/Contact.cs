using DocumentationWebSiteApi.Database.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Contact : AudiTable
    {
        [NotMapped]
        public IEnumerable<MultiLanguageText> Name => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Name);

        public string? Icon { get; set; }
        public Guid AboutUsId { get; set; }
        public AboutUs? AboutUs { get; set; }
    }
}
