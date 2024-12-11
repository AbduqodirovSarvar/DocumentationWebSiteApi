using Microsoft.AspNetCore.Http;

namespace DocumentationWebSiteApi.Services.Abstractions.Interfaces
{
    public interface IFileService
    {
        Task<string> FileExistAsync(IFormFile file);
        string FileGetAsync(string path);

    }
}
