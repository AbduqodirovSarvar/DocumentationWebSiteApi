using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class LanguageEntityTypeConfiguration : AudiTableEntityConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Texts)
                   .WithOne(x => x.Language)
                   .HasForeignKey(x => x.LanguageId);

            builder.HasIndex(x => x.Key).IsUnique();
        }
    }
}
