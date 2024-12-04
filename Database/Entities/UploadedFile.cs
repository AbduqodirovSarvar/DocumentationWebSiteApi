using DocumentationWebSiteApi.Database.Entities.Abstractions;

namespace DocumentationWebSiteApi.Database.Entities
{
    public class UploadedFile : AudiTable
    {
        public string FileName { get; set; } = string.Empty;
        public string Alt { get; set; } = string.Empty;
        public string FileExtention { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string FileSize { get; set; } = string.Empty;
        public string FileUrl { get; set; } = string.Empty;
        public Guid ContentId { get; set; }
        public Content? Content { get; set; }
    }
}
