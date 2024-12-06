using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class AddressEntityTypeConfiguration : AudiTableEntityConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);
        }
    }
}
