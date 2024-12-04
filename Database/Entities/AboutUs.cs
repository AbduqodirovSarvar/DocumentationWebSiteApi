using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class AboutUs : AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public ICollection<MultiLanguageText> Description { get; set; } = [];
        public ICollection<Contact> Contacts { get; set; } = [];
        public Guid AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
