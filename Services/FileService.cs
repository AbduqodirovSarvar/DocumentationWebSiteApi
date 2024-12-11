using DocumentationWebSiteApi.Services.Abstractions.Interfaces;

namespace DocumentationWebSiteApi.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _env;
        const string  contentType = "application/octet-stream";

        public FileService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<string> FileExistAsync(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new Exception("Fayl yuklanmagan.");
            }

            string uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");

            Directory.CreateDirectory(uploadsFolder); // Agar papka bo'lmasa, yaratadi

            string addName = Guid.NewGuid().ToString();

            string filePath = Path.Combine(uploadsFolder, addName + file.FileName).Replace(" ", "_");

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
                fileStream.Close();
            }

            return filePath;
        }

        public string FileGetAsync(string fileName)
        {
            string fullPath = Path.Combine(_env.WebRootPath, "uploads", fileName);

            if (!File.Exists(fullPath))
            {
                throw new Exception($"Fayl topilmadi: {fileName}");
            }

            return fullPath;
        }
    }
}
