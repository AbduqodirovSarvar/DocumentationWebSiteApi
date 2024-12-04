using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class MultiLanguageTextEntityTypeConfiguration : AudiTableEntityConfiguration<MultiLanguageText>
    {
        public override void Configure(EntityTypeBuilder<MultiLanguageText> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Language).WithMany(x => x.Texts).HasForeignKey(x => x.LanguageId);
            builder.
        }
    }
}
