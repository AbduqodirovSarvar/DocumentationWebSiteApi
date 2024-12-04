using DocumentationWebSiteApi.Database.Entities;
using DocumentationWebSiteApi.Database.Entities.Abstractions;
using DocumentationWebSiteApi.Services.Abstractions.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DocumentationWebSiteApi.Database.EntityFramework
{
    public class AppDbContext(DbContextOptions<AppDbContext> options,
    ICurrentUserService currentUserService) : DbContext(options), IAppDbContext
    {
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<HeadCategory> HeadCategories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MultiLanguageText> MultiLanguageTexts { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<UploadedFile> UploadedFiles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditableEntity();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetAuditableEntity()
        {
            foreach (var entry in ChangeTracker.Entries<AudiTable>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedBy = _currentUserService.Id;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedBy = _currentUserService.Id;
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }
        }
    }
}
