using DocumentationWebSiteApi.Database.Entities.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions
{
    public class DeletableEntityTableConfiguration<TEntity> : EntityBaseTableConfiguration<TEntity> where TEntity : DeletableEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
}
