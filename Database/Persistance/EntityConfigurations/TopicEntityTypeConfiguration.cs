using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Persistance.EntityConfigurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocumentationWebSiteApi.Database.Persistance.EntityConfigurations
{
    public class TopicEntityTypeConfiguration : AudiTableEntityConfiguration<Topic>
    {
        public override void Configure(EntityTypeBuilder<Topic> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Contents).WithOne(x => x.Topic).HasForeignKey(x => x.TopicId);
        }
    }
}
