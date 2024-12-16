using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Module")]
    [ApiController]
    public class ModulesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // Av Björn Lindqvist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModuleDto>>> GetModule()
        {
            if (_context.Module == null)
            {
                XC.ERR("No modules were found");
                return NotFound("No modules were found");
            }

            var dto = _context.Module
                .Select(d => new ModuleDto
                {
                    Id = d.Id,
                    Morder = d.Morder,
                    Name = d.Name,
                    Description = d.Description,
                    StartDate = d.StartDate,
                    EndDate = d.EndDate,
                    Select = d.Select,
                    CourseId = (int)d.CourseId!
                });

            XC.INF("The get all method (module) was successful");
            return await dto.ToListAsync();
        }

        //// GET: api/Modules/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Module>> GetModule(int id)
        //{
        //    if (_context.Module == null)
        //    {
        //        XC.ERR("No modules were found");
        //        return NotFound("No modules were found");
        //    }
        //    var @module = await _context.Module.FindAsync(id);

        //    if (@module == null)
        //    {
        //        XC.ERR("The module was not found");
        //        return NotFound("The module was not found");
        //    }

        //    XC.INF("The get one method (module) was successful");
        //    return @module;
        //}

        // PUT: api/Modules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModule(int id, Module @module)
        {
            if (id != @module.Id)
            {
                XC.ERR("The module and the corresponding id are different");
                return Problem("The module and the corresponding id are different");
            }

            _context.Entry(@module).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (module) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(id))
                {
                    XC.ERR("The module while saving was not found");
                    return NotFound("The module while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (module)");
                    return Problem("Cannot save (module)");
                }
            }

            return NoContent();
        }

        // POST: api/Modules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Module>> PostModule(Module @module)
        {
            if (_context.Module == null)
            {
                XC.ERR("Entity set 'ApplicationDbContext.Module' is null");
                return Problem("Entity set 'ApplicationDbContext.Module' is null");
            }
            _context.Module.Add(@module);
            await _context.SaveChangesAsync();

            XC.INF("The post method (module) was successful");
            return CreatedAtAction("GetModule", new { id = @module.Id }, @module);
        }

        // DELETE: api/Modules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModule(int id)
        {
            if (_context.Module == null)
            {
                XC.ERR("No modules were found");
                return NotFound("No modules were found");
            }

            var @module = await _context.Module.FindAsync(id);
            if (@module == null)
            {
                XC.ERR("The module was not found");
                return NotFound("The module was not found");
            }

            _context.Module.Remove(@module);
            await _context.SaveChangesAsync();

            XC.INF("The delete method (module) was successful");
            return NoContent();
        }

        private bool ModuleExists(int id)
        {
            return (_context.Module?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
