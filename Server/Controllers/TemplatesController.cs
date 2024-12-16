using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.IO.Compression;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Shared.ServiceFileData;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Template")]
    [ApiController]
    public class TemplatesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet("{courseId}/{fileName}")] // Copilot: EXPORT - Bygger en zipfil med en kurs i (template).
        public async Task<IActionResult> ExportCourseTemplate(int courseId, string fileName)
        {
            // Hämta kursen och relaterade moduler och aktiviteter
            var course = await _context.Course
                .Include(m => m.Modules)
                .ThenInclude(a => a.Activities)
                .FirstOrDefaultAsync(c => c.Id == courseId);

            if (course == null)
            {
                XC.ERR("The course was not found");
                return NotFound("The course was not found");
            }

            List<Document> documents = [];

            // Hämtar dokument som hör till kursen
            foreach (var doc in _context.Document)
            {

                if (doc.Id4Course == course.Id) documents.Add(doc); // Kursdokument

                foreach (var mod in course.Modules)
                {
                    if (mod.Id == doc.ModuleId) documents.Add(doc); // Moduldokument

                    foreach (var act in mod.Activities)
                    {
                        if (act.Id == doc.ActivityId) documents.Add(doc); // Aktivitetsdokument
                    }
                }
            }

            // Konvertera kursdata till JSON
            var jsonCourseData = JsonConvert.SerializeObject(course);

            // Skapa en zipfil
            using var zipStream = new MemoryStream();
            using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Create, true))
            {
                // Lägg till en textfil med ett identifierbart namn och som rymmer innehållsdata
                var dataEntry = archive.CreateEntry("id#bil64lms2412.txt");
                using (var dataStream = dataEntry.Open())
                using (var dataWriter = new StreamWriter(dataStream))
                {
                    await dataWriter.WriteAsync($"{course.Name}"); // Det verkliga namnet för kursen
                    await dataWriter.WriteAsync($"|***|{course.Modules.Count}"); // Antal moduler
                    var actcount = course.Modules.Sum(a => a.Activities.Count);
                    await dataWriter.WriteAsync($"|***|{actcount}"); // Antal aktiviteter
                    await dataWriter.WriteAsync($"|***|{documents.Count}"); // Antal dokument
                }

                // Lägg till kursen från databasen
                var jsonFile1 = archive.CreateEntry("coursetemplate.json");
                using (var entryStream = jsonFile1.Open())
                using (var streamWriter = new StreamWriter(entryStream))
                {
                    await streamWriter.WriteAsync(jsonCourseData);
                }

                // Lägg till dokument och dokumentfiler om det finns några
                if (documents.Count > 0)
                {
                    // Konvertera dokumentdata till JSON
                    var jsonDocumentData = JsonConvert.SerializeObject(documents);

                    // Lägg till dokumenten från databasen
                    var jsonFile2 = archive.CreateEntry("documenttemplate.json");
                    using (var entryStream = jsonFile2.Open())
                    using (var streamWriter = new StreamWriter(entryStream))
                    {
                        await streamWriter.WriteAsync(jsonDocumentData);
                    }

                    // Lägger till dokumentfilerna från wwwroot/Documents
                    foreach (var doc in documents)
                    {
                        var fName = $"{doc.NameIx}{doc.DocName}";
                        var fileEntry = archive.CreateEntry($"docfiles/{fName}");

                        try
                        {
                            using var fileStream = new FileStream($"wwwroot/Documents/{fName}", FileMode.Open);
                            using var entryStream = fileEntry.Open();
                            await fileStream.CopyToAsync(entryStream);
                        }
                        catch (Exception ex)
                        {
                            XC.ERR($"Error copying document file: {ex.Message}");
                        }
                    }
                }
            }

            zipStream.Seek(0, SeekOrigin.Begin);
            var zfile = new ZFile
            {
                Zcontent = zipStream.ToArray(),
                Zname = fileName + ".zip",
                Ztype = "application/zip"
            };

            return Ok(zfile);
        }

        [HttpPost("{dTemplateJson}")] // Copilot: IMPORT - Adderar en kurs från en zipfil (template).
        public async Task<IActionResult> ImportCourseTemplate([FromBody] string cTemplateJson, string dTemplateJson)
        {
            if (string.IsNullOrEmpty(cTemplateJson))
            {
                XC.ERR("Course template JSON is null or empty");
                return Problem("Course template JSON is null or empty");
            }

            // Ordböcker och en lista för att mappa gamla ID-värden till nya ID-värden
            int oldCourseId = 0;
            int newCourseId = 0;
            var moduleIdMap = new Dictionary<int, int>();
            var activityIdMap = new Dictionary<int, int>();
            var oldListId = new List<int>();

            var course = JsonConvert.DeserializeObject<Course>(cTemplateJson);
            if (course != null)
            {
                oldCourseId = course.Id; // Sparar gammalt id-värde.
                course.Id = 0; // Förhindrar explicit infogning

                foreach (var mod in course.Modules)
                {
                    oldListId.Add(mod.Id); // Sparar gamla id-värden.
                    mod.Id = 0; // Förhindrar explicit infogning

                    foreach (var act in mod.Activities)
                    {
                        oldListId.Add(act.Id); // Sparar gamla id-värden.
                        act.Id = 0; // Förhindrar explicit infogning
                    }
                }

                // Lägger till kursen inklusive dess moduler och aktiviteter till databasen
                _context.Course.Add(course);
                await _context.SaveChangesAsync();

                // Uppdatera de temporära ID-nycklarna med de nya ID-värdena
                newCourseId = course.Id;
                int count = 0;
                foreach (var mod in course.Modules)
                {
                    moduleIdMap[oldListId[count]] = mod.Id;
                    count++;
                    foreach (var act in mod.Activities)
                    {
                        activityIdMap[oldListId[count]] = act.Id;
                        count++;
                    }
                }
            }

            if (dTemplateJson != "no accessible data") // Om dokument saknas.
            {
                // Deserialize JSON till en lista av Document-objekt
                var documentTemplates = JsonConvert.DeserializeObject<List<Document>>(dTemplateJson);

                if (documentTemplates != null)
                {
                    // Lägger till varje dokument (post) i databasen
                    foreach (var doc in documentTemplates)
                    {
                        if (doc.Id4Course == oldCourseId)
                        {
                            doc.Id4Course = newCourseId; // Uppdaterar id-värdet.
                        }

                        if (doc.ModuleId > 0)
                        {
                            doc.ModuleId = moduleIdMap[doc.ModuleId]; // Uppdaterar id-värdet.
                        }

                        if (doc.ActivityId > 0)
                        {
                            doc.ActivityId = activityIdMap[doc.ActivityId]; // Uppdaterar id-värdet.
                        }

                        doc.Id = 0; // Förhindrar explicit infogning
                        _context.Document.Add(doc);
                    }
                }
                else
                {
                    XC.ERR("Invalid document templates JSON");
                    return Problem("Invalid document templates JSON");
                }

                await _context.SaveChangesAsync();
            }

            return NoContent();
        }
    }
}
