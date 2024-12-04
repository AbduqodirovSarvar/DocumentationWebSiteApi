using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class ContentEntityTypeConfiguration : AudiTableEntityConfiguration<Content>
    {
        public override void Configure(EntityTypeBuilder<Content> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Images).WithOne(x => x.Content).HasForeignKey(x => x.ContentId);
        }
    }
}
