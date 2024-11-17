using System.Net;
using LexiconLMSBlazor.Shared.DocFileData;
using LexiconLMSBlazor.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LexiconLMSBlazor.Server.Controllers
{
    [ApiController]
    [Route("Filesave")]
    public class FilesaveController(IWebHostEnvironment env, ILogger<FilesaveController> logger) : ControllerBase
    {
        private readonly IWebHostEnvironment env = env;
        private readonly ILogger<FilesaveController> logger = logger;

        [HttpGet("{filename}")]
        public ActionResult<ExistDto> GetFile(string filename)
        {
            var exist = new ExistDto
            {
                IsFile = System.IO.File.Exists($"wwwroot/Documents/{filename}")
            };

            return exist;
        }

        [HttpPost]
        public async Task<ActionResult<IList<UploadResult>>> PostFile([FromForm] IEnumerable<IFormFile> files)
        {
            var resourcePath = new Uri($"{Request.Scheme}://{Request.Host}/");
            List<UploadResult> uploadResults = [];

            foreach (var file in files)
            {
                var uploadResult = new UploadResult();
                string trustedFileNameForFileStorage;
                var untrustedFileName = file.FileName;
                uploadResult.FileName = untrustedFileName;
                var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);

                if (file.Length > 0)
                {
                    try
                    {
                        trustedFileNameForFileStorage = file.FileName;
                        var path = Path.Combine(env.ContentRootPath, "wwwroot/Documents", trustedFileNameForFileStorage);


                        await using FileStream fs = new(path, FileMode.Create);
                        await file.CopyToAsync(fs);

                        logger.LogInformation("{file.FileName} saved at {path}",
                        trustedFileNameForDisplay, path);
                        uploadResult.Uploaded = true;
                    }
                    catch (IOException ex)
                    {
                        logger.LogError("{file.FileName} error on upload (Err: 3): {ex.Message}",
                        trustedFileNameForDisplay, ex.Message);
                        uploadResult.ErrorCode = 3;
                    }
                }
                else
                {
                    logger.LogInformation("{file.FileName} length is 0 (Err: 1)", trustedFileNameForDisplay);
                    uploadResult.ErrorCode = 1;
                }

                uploadResults.Add(uploadResult);
            }

            return new CreatedResult(resourcePath, uploadResults);
        }

        [HttpDelete("{filename}")]
        public IActionResult DeleteFile(string filename)
        {
            System.IO.File.Delete($"wwwroot/Documents/{filename}");

            return NoContent();
        }
    }
}