using DocumentationWebSiteApi.Database.Entities.Abstractions.Interfaces;

namespace DocumentationWebSiteApi.Database.Entities.Abstractions
{
    public abstract class DeletableEntity : EntityBase, IEntityBase, IDeletable
    {
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
