using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Register>> GetRegister(int id)
        {
            if (_context.Register == null)
            {
                return NotFound();
            }
            var @register = await _context.Register.FindAsync(id);

            if (@register == null)
            {
                return NotFound();
            }

            return @register;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegister(int id, Register @register)
        {
            if (id != @register.Id)
            {
                return BadRequest();
            }

            _context.Entry(@register).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegisterExists(id))
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

        private bool RegisterExists(int id)
        {
            return (_context.Register?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
