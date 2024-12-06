﻿using DocumentationWebSiteApi.Database.Entities.Abstractions;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class AboutUs : AudiTable
    {
        [NotMapped]
        public IEnumerable<MultiLanguageText> Name => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Name);
        [NotMapped]
        public IEnumerable<MultiLanguageText> Description => MultiLanguageTexts.Where(t => t.MetaDataType == Enumerations.MetaDataType.Description);
        public ICollection<Contact> Contacts { get; set; } = [];
        public Guid AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
