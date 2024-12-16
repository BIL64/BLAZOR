using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Document")]
    [ApiController]
    public class DocumentsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // GET: api/Documents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDto>>> GetDocument()
        {
            if (_context.Document == null)
            {
                XC.ERR("No documents were found");
                return NotFound("No documents were found");
            }

            var dto = _context.Document
                  .Select(d => new DocumentDto
                  {
                      Id = d.Id,
                      NameIx = d.NameIx,
                      DocName = d.DocName,
                      Description = d.Description,
                      Author = d.Author,
                      TimeStamp = d.TimeStamp,
                      UserId = d.UserId,
                      Id4Course = d.Id4Course,
                      ModuleId = d.ModuleId,
                      ActivityId = d.ActivityId
                  });

            XC.INF("The get all method (document) was successful");
            return await dto.ToListAsync();
        }

        //// GET: api/Documents/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Document>> GetDocument(int id)
        //{
        //  if (_context.Document == null)
        //  {
        //      XC.ERR("No documents were found");
        //      return NotFound("No documents were found");
        //  }
        //    var document = await _context.Document.FindAsync(id);

        //    if (document == null)
        //    {
        //        XC.ERR("The document was not found");
        //        return NotFound("The document was not found");
        //    }

        //    XC.INF("The get one method (document) was successful");
        //    return document;
        //}

        // PUT: api/Documents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocument(int id, Document document)
        {
            if (id != document.Id)
            {
                XC.ERR("The document and the corresponding id are different");
                return Problem("The document and the corresponding id are different");
            }

            _context.Entry(document).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (document) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentExists(id))
                {
                    XC.ERR("The document while saving was not found");
                    return NotFound("The document while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (document)");
                    return Problem("Cannot save (document)");
                }
            }

            return NoContent();
        }

        // POST: api/Documents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Document>> PostDocument(Document document)
        {
          if (_context.Document == null)
          {
                XC.ERR("Entity set 'ApplicationDbContext.Document' is null");
                return Problem("Entity set 'ApplicationDbContext.Document' is null");
          }
            _context.Document.Add(document);
            await _context.SaveChangesAsync();

            XC.INF("The post method (document) was successful");
            return CreatedAtAction("GetDocument", new { id = document.Id }, document);
        }

        // DELETE: api/Documents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocument(int id)
        {
            if (_context.Document == null)
            {
                XC.ERR("No documents were found");
                return NotFound("No documents were found");
            }
            var document = await _context.Document.FindAsync(id);
            if (document == null)
            {
                XC.ERR("The document was not found");
                return NotFound("The document was not found");
            }

            _context.Document.Remove(document);
            await _context.SaveChangesAsync();

            XC.INF("The delete method (document) was successful");
            return NoContent();
        }

        private bool DocumentExists(int id)
        {
            return (_context.Document?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
