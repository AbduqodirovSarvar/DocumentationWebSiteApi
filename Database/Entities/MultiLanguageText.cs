using DocumentationWebSiteApi.Database.Entities.Abstractions;
using DocumentationWebSiteApi.Database.Enumerations;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class MultiLanguageText : AudiTable
    {
        public Guid LanguageId { get; set; }
        public Language? Language { get; set; }
        public string Text { get; set; } = string.Empty;

        public MetaDataType MetaDataType { get; set; }

        public Guid? AboutUsId { get; set; }
        public AboutUs? AboutUs { get; set; }

        public Guid? AddressId { get; set; }
        public Address? Address { get; set; }

        public Guid? CategoryId { get; set; }
        public Category? Category { get; set; }

        public Guid? ContactId { get; set; }
        public Contact? Contact { get; set; }

        public Guid? ContentId { get; set; }
        public Content? Content { get; set; }

        public Guid? HeadCategoryId { get; set; }
        public HeadCategory? HeadCategory { get; set; }

        public Guid? SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }

        public Guid? TopicId { get; set; }
        public Topic? Topic { get; set; }
    }
}
