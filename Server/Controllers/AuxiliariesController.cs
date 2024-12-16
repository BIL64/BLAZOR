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
                XC.ERR("No content");
                return NotFound("No content");
            }
            var @auxiliary = await _context.Auxiliary.FindAsync(id);

            if (@auxiliary == null)
            {
                XC.ERR("The request was not found");
                return NotFound("The request was not found");
            }

            XC.INF("The get one method (auxiliary) was successful");
            return @auxiliary;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuxiliary(int id, Auxiliary @auxiliary)
        {
            if (id != @auxiliary.Id)
            {
                XC.ERR("The request and the corresponding id are different");
                return Problem("The request and the corresponding id are different");
            }

            _context.Entry(@auxiliary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (auxiliary) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuxiliaryExists(id))
                {
                    XC.ERR("The request while saving was not found");
                    return NotFound("The request while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (auxiliary)");
                    return Problem("Cannot save (auxiliary)");
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
