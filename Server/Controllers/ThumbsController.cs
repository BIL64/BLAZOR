using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Thumb")]
    [ApiController]
    public class ThumbController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // Av Björn Lindqvist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThumbDto>>> GetThumb()
        {
            if (_context.Thumb == null)
            {
                return BadRequest();
            }

            var dto = _context.Thumb
                .Select(d => new ThumbDto
                {
                    Id = d.Id,
                    IsLike = d.IsLike,
                    Name = d.Name,
                    Id4User = d.Id4User,
                    Id4Post = d.Id4Post
                });

            return await dto.ToListAsync();
        }

        //// GET: api/Thumbs/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Thumb>> GetThumb(int id)
        //{
        //    if (_context.Thumb == null)
        //    {
        //        return NotFound();
        //    }
        //    var @thumb = await _context.Thumb.FindAsync(id);

        //    if (@thumb == null)
        //    {
        //        return NotFound();
        //    }

        //    return @thumb;
        //}

        // PUT: api/Thumbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThumb(int id, Thumb @thumb)
        {
            if (id != @thumb.Id)
            {
                return BadRequest();
            }

            _context.Entry(@thumb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThumbExists(id))
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

        // POST: api/Thumbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Thumb>> PostThumb(Thumb @thumb)
        {
            if (_context.Thumb == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Thumb'  is null.");
            }
            _context.Thumb.Add(@thumb);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThumb", new { id = @thumb.Id }, @thumb);
        }

        // DELETE: api/Thumbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThumb(int id)
        {
            if (_context.Thumb == null)
            {
                return NotFound();
            }

            var @thumb = await _context.Thumb.FindAsync(id);
            if (@thumb == null)
            {
                return NotFound();
            }

            _context.Thumb.Remove(@thumb);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThumbExists(int id)
        {
            return (_context.Thumb?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
