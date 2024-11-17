using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Auxiliary")]
    [ApiController]
    public class AuxiliariesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        [HttpGet("{id}")]
        public async Task<ActionResult<Auxiliary>> GetAuxiliary(int id)
        {
            if (_context.Auxiliary == null)
            {
                return NotFound();
            }
            var @auxiliary = await _context.Auxiliary.FindAsync(id);

            if (@auxiliary == null)
            {
                return NotFound();
            }

            return @auxiliary;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuxiliary(int id, Auxiliary @auxiliary)
        {
            if (id != @auxiliary.Id)
            {
                return BadRequest();
            }

            _context.Entry(@auxiliary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuxiliaryExists(id))
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

        private bool AuxiliaryExists(int id)
        {
            return (_context.Auxiliary?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
