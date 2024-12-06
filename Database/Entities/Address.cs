using DocumentationWebSiteApi.Database.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Address : AudiTable
    {
        [NotMapped]
        public IEnumerable<MultiLanguageText> Name => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Name);

        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
