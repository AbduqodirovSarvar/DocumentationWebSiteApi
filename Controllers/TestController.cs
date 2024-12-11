using DocumentationWebSiteApi.Services.Abstractions.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace DocumentationWebSiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IFileService _fileService;
        private readonly IConfiguration _configuration;
        public TestController(IFileService fileService, IConfiguration configuration)
        {
            _fileService = fileService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> CreateFile(IFormFile file)
        {
            var filePath = await _fileService.FileExistAsync(file);

            return Ok(filePath);
        }

        [HttpGet]
        public ActionResult GetFile(string filePath)
        { 
            var fullPath = _fileService.FileGetAsync(filePath);

            return File(System.IO.File.OpenRead(fullPath), _configuration["ContentType:File"]!, fullPath);
        }
    }
}
