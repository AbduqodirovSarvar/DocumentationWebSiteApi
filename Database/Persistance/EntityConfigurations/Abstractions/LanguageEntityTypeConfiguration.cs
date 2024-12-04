using DocumentationWebSiteApi.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions
{
    public class LanguageEntityTypeConfiguration : AudiTableEntityConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            base.Configure(builder);
            builder.HasIndex(x => x.Key).IsUnique();
        }
    }
}
