using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Acttype")]
    [ApiController]
    public class ActivityTypesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // GET: api/ActivityTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityTypeDto>>> GetActivityType()
        {
            if (_context.ActivityType == null)
            {
                XC.ERR("No activity types were found");
                return NotFound("No activity types were found");
            }

            var dto = _context.ActivityType
                .Select(d => new ActivityTypeDto
                {
                    Id = d.Id,
                    Name = d.Name
                });

            XC.INF("The get all method (activity type) was successful");
            return await dto.ToListAsync();
        }

        //// GET: api/ActivityTypes/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<ActivityType>> GetActivityType(int id)
        //{
        //    if (_context.ActivityType == null)
        //    {
        //        XC.ERR("No activity types were found");
        //        return NotFound("No activity types were found");
        //    }
        //    var activityType = await _context.ActivityType.FindAsync(id);

        //    if (activityType == null)
        //    {
        //        XC.ERR("The activity type was not found");
        //        return NotFound("The activity type was not found");
        //    }

        //    XC.INF("The get one method (activity type) was successful");
        //    return activityType;
        //}

        // PUT: api/ActivityTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityType(int id, ActivityType activityType)
        {
            if (id != activityType.Id)
            {
                XC.ERR("The activity type and the corresponding id are different");
                return Problem("The activity type and the corresponding id are different");
            }

            _context.Entry(activityType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (activity type) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityTypeExists(id))
                {
                    XC.ERR("The activity type while saving was not found");
                    return NotFound("The activity type while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (activity type)");
                    return Problem("Cannot save (activity type)");
                }
            }

            return NoContent();
        }

        // POST: api/ActivityTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ActivityType>> PostActivityType(ActivityType activityType)
        {
          if (_context.ActivityType == null)
          {
                XC.ERR("Entity set 'ApplicationDbContext.ActivityType' is null");
                return Problem("Entity set 'ApplicationDbContext.ActivityType' is null");
          }
            _context.ActivityType.Add(activityType);
            await _context.SaveChangesAsync();

            XC.INF("The post method (activity type) was successful");
            return CreatedAtAction("GetActivityType", new { id = activityType.Id }, activityType);
        }

        // DELETE: api/ActivityTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivityType(int id)
        {
            if (_context.ActivityType == null)
            {
                XC.ERR("No activity types were found");
                return NotFound("No activity types were found");
            }
            var activityType = await _context.ActivityType.FindAsync(id);
            if (activityType == null)
            {
                XC.ERR("The activity type was not found");
                return NotFound("The activity type was not found");
            }

            _context.ActivityType.Remove(activityType);
            await _context.SaveChangesAsync();

            XC.INF("The delete method (activity type) was successful");
            return NoContent();
        }

        private bool ActivityTypeExists(int id)
        {
            return (_context.ActivityType?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
