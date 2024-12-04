namespace DocumentationWebSiteApi.Database.Entities.Abstractions.Interfaces
{
    public interface IDeletable
    {
        public bool IsDeleted { get; set; }
        protected DateTime? DeletedAt { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
