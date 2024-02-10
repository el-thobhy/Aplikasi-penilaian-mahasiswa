using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplikasiPenilaianMahasiswa.Api.DataModel;
using ApplikasiPenilaianMahasiswa.Api.Security;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace ApplikasiPenilaianMahasiswa.Api.Repositories
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private IWebHostEnvironment _webHostEnvironment;
        private HomeRepositories _repo;

        public HomeController(IWebHostEnvironment webHostEnvironment, MahasiswaDbContext dbContext)
        {
            _webHostEnvironment = webHostEnvironment;
            _repo = new HomeRepositories(dbContext);
        }

        [HttpPost("upload")]
        [DisableRequestSizeLimit]
        [ReadableBodyStream(Roles = "Administrator, home")]
        public async Task<IActionResult> Upload(CancellationToken ct)
        {
            if (Request.Form.Files.Count == 0) return NoContent();

            var file = Request.Form.Files[0];
            var filePath = SaveFile(file);
            ResponseResult result = _repo.Upload(filePath);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        private string SaveFile(IFormFile file)
        {
            if (file.Length == 0)
            {
                throw new BadHttpRequestException("File is Empty");
            }

            var extesion = Path.GetExtension(file.FileName);

            var webRootPath = _webHostEnvironment.WebRootPath;
            if (string.IsNullOrWhiteSpace(webRootPath))
            {
                webRootPath = Path.Combine(Directory.GetCurrentDirectory(), "uploaded");
            }

            var folderPath = Path.Combine(webRootPath, "upload");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var fileName = $"file_{extesion}";
            var filePath = Path.Combine(folderPath, fileName);
            using var stream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(stream);

            return filePath;
        }
    }
}