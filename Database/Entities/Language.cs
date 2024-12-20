﻿using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Language : AudiTable
    {
        public string Value { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
        public ICollection<MultiLanguageText> Texts { get; set; } = [];
    }
}
