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

            builder.HasOne(x => x.AboutUs).WithMany(x => x.MultiLanguageTexts).HasForeignKey(x => x.AboutUsId);
            builder.HasOne(x => x.Address).WithMany(x => x.MultiLanguageTexts).HasForeignKey(x => x.AddressId);
            builder.HasOne(x => x.Category).WithMany(x => x.MultiLanguageTexts).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Contact).WithMany(x => x.MultiLanguageTexts).HasForeignKey(x => x.ContactId);
            builder.HasOne(x => x.Content).WithMany(x => x.MultiLanguageTexts).HasForeignKey(x => x.ContentId);
            builder.HasOne(x => x.HeadCategory).WithMany(x => x.MultiLanguageTexts).HasForeignKey(x => x.HeadCategoryId);
            builder.HasOne(x => x.SubCategory).WithMany(x => x.MultiLanguageTexts).HasForeignKey(x => x.SubCategoryId);
            builder.HasOne(x => x.Topic).WithMany(x => x.MultiLanguageTexts).HasForeignKey (x => x.TopicId);

            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.AboutUsId }).IsUnique();
            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.AddressId }).IsUnique();
            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.CategoryId }).IsUnique();
            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.ContactId }).IsUnique();
            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.ContentId }).IsUnique();
            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.HeadCategoryId }).IsUnique();
            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.SubCategoryId }).IsUnique();
            builder.HasIndex(x => new { x.LanguageId, x.MetaDataType, x.TopicId }).IsUnique();
        }
    }
}
