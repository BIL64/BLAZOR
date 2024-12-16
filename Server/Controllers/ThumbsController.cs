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
                XC.ERR("No thumbs were found");
                return NotFound("No thumbs were found");
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

            XC.INF("The get all method (thumb) was successful");
            return await dto.ToListAsync();
        }

        //// GET: api/Thumbs/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Thumb>> GetThumb(int id)
        //{
        //    if (_context.Thumb == null)
        //    {
        //        XC.ERR("No thumbs were found");
        //        return NotFound("No thumbs were found");
        //    }
        //    var @thumb = await _context.Thumb.FindAsync(id);

        //    if (@thumb == null)
        //    {
        //        XC.ERR("The thumb was not found");
        //        return NotFound("The thumb was not found");
        //    }

        //    XC.INF("The get one method (thumb) was successful");
        //    return @thumb;
        //}

        // PUT: api/Thumbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThumb(int id, Thumb @thumb)
        {
            if (id != @thumb.Id)
            {
                XC.ERR("The thumb and the corresponding id are different");
                return Problem("The thumb and the corresponding id are different");
            }

            _context.Entry(@thumb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (thumb) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThumbExists(id))
                {
                    XC.ERR("The thumb while saving was not found");
                    return NotFound("The thumb while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (thumb)");
                    return Problem("Cannot save (thumb)");
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
                XC.ERR("Entity set 'ApplicationDbContext.Thumb' is null");
                return Problem("Entity set 'ApplicationDbContext.Thumb' is null");
            }
            _context.Thumb.Add(@thumb);
            await _context.SaveChangesAsync();

            XC.INF("The post method (thumb) was successful");
            return CreatedAtAction("GetThumb", new { id = @thumb.Id }, @thumb);
        }

        // DELETE: api/Thumbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteThumb(int id)
        {
            if (_context.Thumb == null)
            {
                XC.ERR("No thumbs were found");
                return NotFound("No thumbs were found");
            }

            var @thumb = await _context.Thumb.FindAsync(id);
            if (@thumb == null)
            {
                XC.ERR("The thumb was not found");
                return NotFound("The thumb was not found");
            }

            _context.Thumb.Remove(@thumb);
            await _context.SaveChangesAsync();

            XC.INF("The delete method (thumb) was successful");
            return NoContent();
        }

        private bool ThumbExists(int id)
        {
            return (_context.Thumb?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
