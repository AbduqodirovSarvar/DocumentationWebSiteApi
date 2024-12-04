using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Address : AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
