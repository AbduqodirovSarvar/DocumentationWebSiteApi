using DocumentationWebSiteApi.Database.Entities.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions
{
    public class AudiTableEntityConfiguration<TEntity> : DeletableEntityTableConfiguration<TEntity> where TEntity : AudiTable
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
}
