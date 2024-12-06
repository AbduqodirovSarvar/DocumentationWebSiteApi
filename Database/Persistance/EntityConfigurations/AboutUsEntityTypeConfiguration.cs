using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class AboutUsEntityTypeConfiguration : AudiTableEntityConfiguration<AboutUs>
    {
        public override void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Contacts).WithOne(x => x.AboutUs).HasForeignKey(x => x.AboutUsId);
            builder.HasOne(x => x.Address).WithOne().HasForeignKey<AboutUs>(x => x.AddressId);

        }
    }
}
