using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class HeadCategoryEntityTypeConfiguration : AudiTableEntityConfiguration<HeadCategory>
    {
        public override void Configure(EntityTypeBuilder<HeadCategory> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Categories).WithOne(x => x.HeadCategory).HasForeignKey(x => x.HeadCategoryId);
        }
    }
}
