using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Forum")]
    [ApiController]
    public class ForumController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // Av Björn Lindqvist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ForumDto>>> GetForum()
        {
            if (_context.Forum == null)
            {
                return BadRequest();
            }

            var dto = _context.Forum
                .Select(d => new ForumDto
                {
                    Id = d.Id,
                    ThreadName = d.ThreadName,
                    Date = d.Date,
                    Text = d.Text,
                    AuxHead = d.AuxHead,
                    Id4User = d.Id4User,
                    Edited = d.Edited,
                    Pmail = d.Pmail,
                    IsMan = d.IsMan,
                    Select = d.Select,
                    Id4Course = d.Id4Course
                });

            return await dto.ToListAsync();
        }

        //// GET: api/Forum/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Forum>> GetForum(int id)
        //{
        //    if (_context.Forum == null)
        //    {
        //        return NotFound();
        //    }
        //    var @forum = await _context.Forum.FindAsync(id);

        //    if (@forum == null)
        //    {
        //        return NotFound();
        //    }

        //    return @forum;
        //}

        // PUT: api/Forum/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForum(int id, Forum @forum)
        {
            if (id != @forum.Id)
            {
                return BadRequest();
            }

            _context.Entry(@forum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForumExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Forum
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Forum>> PostForum(Forum @forum)
        {
            if (_context.Forum == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Forum'  is null.");
            }
            _context.Forum.Add(@forum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForum", new { id = @forum.Id }, @forum);
        }

        // DELETE: api/Forum/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForum(int id)
        {
            if (_context.Forum == null)
            {
                return NotFound();
            }

            var @forum = await _context.Forum.FindAsync(id);
            if (@forum == null)
            {
                return NotFound();
            }

            _context.Forum.Remove(@forum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForumExists(int id)
        {
            return (_context.Forum?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
