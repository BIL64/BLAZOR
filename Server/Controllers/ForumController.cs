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
                XC.ERR("No threads were found");
                return NotFound("No threads were found");
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

            XC.INF("The get all method (forum) was successful");
            return await dto.ToListAsync();
        }

        //// GET: api/Forum/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Forum>> GetForum(int id)
        //{
        //    if (_context.Forum == null)
        //    {
        //        XC.ERR("No threads were found");
        //        return NotFound("No threads were found");
        //    }
        //    var @forum = await _context.Forum.FindAsync(id);

        //    if (@forum == null)
        //    {
        //        XC.ERR("The thread was not found");
        //        return NotFound("The thread was not found");
        //    }

        //    XC.INF("The get one method (forum) was successful");
        //    return @forum;
        //}

        // PUT: api/Forum/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForum(int id, Forum @forum)
        {
            if (id != @forum.Id)
            {
                XC.ERR("The thread and the corresponding id are different");
                return Problem("The thread and the corresponding id are different");
            }

            _context.Entry(@forum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (forum) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForumExists(id))
                {
                    XC.ERR("The thread while saving was not found");
                    return NotFound("The thread while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (forum)");
                    return Problem("Cannot save (forum)");
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
                XC.ERR("Entity set 'ApplicationDbContext.Forum' is null");
                return Problem("Entity set 'ApplicationDbContext.Forum' is null");
            }
            _context.Forum.Add(@forum);
            await _context.SaveChangesAsync();

            XC.INF("The post method (forum) was successful");
            return CreatedAtAction("GetForum", new { id = @forum.Id }, @forum);
        }

        // DELETE: api/Forum/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForum(int id)
        {
            if (_context.Forum == null)
            {
                XC.ERR("No threads were found");
                return NotFound("No threads were found");
            }

            var @forum = await _context.Forum.FindAsync(id);
            if (@forum == null)
            {
                XC.ERR("The thread was not found");
                return NotFound("The thread was not found");
            }

            _context.Forum.Remove(@forum);
            await _context.SaveChangesAsync();

            XC.INF("The delete method (forum) was successful");
            return NoContent();
        }

        private bool ForumExists(int id)
        {
            return (_context.Forum?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
