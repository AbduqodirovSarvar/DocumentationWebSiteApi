namespace DocumentationWebSiteApi.Database.Entities.Abstractions.Interfaces
{
    public interface IAudiTable
    {
        DateTime CreatedAt { get; }
        Guid? CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        Guid? UpdatedBy { get; set; }
    }
}
