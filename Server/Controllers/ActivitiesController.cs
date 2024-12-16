using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Activity")]
    [ApiController]
    public class ActivitiesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // GET: api/Activities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityDto>>> GetActivity()
        {
            if (_context.Activity == null)
            {
                XC.ERR("No activities were found");
                return NotFound("No activities were found");
            }

            var dto = _context.Activity
                .Select(d => new ActivityDto
                {
                    Id = d.Id,
                    Name = d.Name,
                    Description = d.Description,
                    StartDate = d.StartDate,
                    EndDate = d.EndDate,
                    Select = d.Select,
                    ModuleId = (int)d.ModuleId!,
                    ActivityTypeId = (int)d.ActivityTypeId!
                });

            XC.INF("The get all method (activity) was successful");
            return await dto.ToListAsync();
        }

        //// GET: api/Activities/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Activity>> GetActivity(int id)
        //{
        //  if (_context.Activity == null)
        //  {
        //      XC.ERR("No activities were found.");
        //      return NotFound("No activities were found.");
        //  }
        //    var activity = await _context.Activity.FindAsync(id);

        //    if (activity == null)
        //    {
        //      XC.ERR("The activity was not found");
        //      return NotFound("The activity was not found");
        //    }

        //    XC.INF("The get one method (activity) was successful");
        //    return activity;
        //}

        // PUT: api/Activities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivity(int id, Activity activity)
        {
            if (id != activity.Id)
            {
                XC.ERR("The activity and the corresponding id are different");
                return Problem("The activity and the corresponding id are different");
            }

            _context.Entry(activity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (activity) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityExists(id))
                {
                    XC.ERR("The activity while saving was not found");
                    return NotFound("The activity while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (activity)");
                    return Problem("Cannot save (activity)");
                }
            }

            return NoContent();
        }

        // POST: api/Activities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Activity>> PostActivity(Activity activity)
        {
          if (_context.Activity == null)
          {
                XC.ERR("Entity set 'ApplicationDbContext.Activity' is null");
                return Problem("Entity set 'ApplicationDbContext.Activity' is null");
          }
            _context.Activity.Add(activity);
            await _context.SaveChangesAsync();

            XC.INF("The post method (activity) was successful");
            return CreatedAtAction("GetActivity", new { id = activity.Id }, activity);
        }

        // DELETE: api/Activities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            if (_context.Activity == null)
            {
                XC.ERR("No activities were found.");
                return NotFound("No activities were found.");
            }
            var activity = await _context.Activity.FindAsync(id);
            if (activity == null)
            {
                XC.ERR("The activity was not found");
                return NotFound("The activity was not found");
            }

            _context.Activity.Remove(activity);
            await _context.SaveChangesAsync();

            XC.INF("The delete method (activity) was successful");
            return NoContent();
        }

        private bool ActivityExists(int id)
        {
            return (_context.Activity?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
