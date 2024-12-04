using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class SubCategoryEntityTypeConfiguration : AudiTableEntityConfiguration<SubCategory>
    {
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Topics).WithOne(x => x.SubCategory).HasForeignKey(x => x.SubCategoryId);
        }
    }
}
