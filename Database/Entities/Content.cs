using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class Content : AudiTable
    {
        public ICollection<MultiLanguageText> Name { get; set; } = [];
        public ICollection<MultiLanguageText> Description { get; set; } = [];
        public Guid TopicId { get; set; }
        public Topic? Topic { get; set; }
        public ICollection<UploadedFile> Images { get; set; } = [];
    }
}
