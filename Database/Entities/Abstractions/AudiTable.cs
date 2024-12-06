using DocumentationWebSiteApi.Database.Entities.Abstractions.Interfaces;

namespace DocumentationWebSiteApi.Database.Entities.Abstractions
{
    public abstract class AudiTable : DeletableEntity, IEntityBase, IAudiTable, IDeletable 
    {
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }

        public ICollection<MultiLanguageText> MultiLanguageTexts { get; set; } = [];
    }
}
