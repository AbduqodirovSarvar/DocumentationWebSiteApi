using DocumentationWebSiteApi.Database.Entities.Abstractions.Interfaces;

namespace DocumentationWebSiteApi.Database.Entities.Abstractions
{
    public abstract class EntityBase : IEntityBase
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}
