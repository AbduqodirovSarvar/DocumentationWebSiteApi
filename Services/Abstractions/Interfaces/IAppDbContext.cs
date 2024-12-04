using DocumentationWebSiteApi.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DocumentationWebSiteApi.Services.Abstractions.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<AboutUs> AboutUs { get; set; }
        DbSet<Address> Address { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Content> Contents { get; set; }
        DbSet<HeadCategory> HeadCategories { get; set; }
        DbSet<Language> Languages { get; set; }
        DbSet<MultiLanguageText> MultiLanguageTexts { get; set; }
        DbSet<SubCategory> SubCategories { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<UploadedFile> UploadedFiles { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
