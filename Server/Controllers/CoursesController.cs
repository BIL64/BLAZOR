using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/Course")]
    [ApiController]
    public class CoursesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;

        // Av Björn Lindqvist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCourse()
        {
            if (_context.Course == null)
            {
                XC.ERR("No courses were found");
                return NotFound("No courses were found");
            }
            
            var dto = _context.Course
                .Select(c => new CourseDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    HideDate = c.HideDate,
                    Total_M = c.Modules.Count,
                    Total_S = c.Users.Count,
                    Modules = c.Modules.Select(m => new ModuleDto
                    {
                        Id = m.Id,
                        Morder = m.Morder,
                        Name = m.Name,
                        Description= m.Description,
                        StartDate = m.StartDate,
                        EndDate = m.EndDate,
                        Select = m.Select,
                        CourseId = (int)m.CourseId!,
                        Activities = m.Activities.Select(a => new ActivityDto
                        {
                            Id = a.Id,
                            Name = a.Name,
                            Description = a.Description,
                            StartDate = a.StartDate,
                            EndDate = a.EndDate,
                            Select = a.Select,
                            ModuleId = (int)a.ModuleId!,
                            ActivityTypeId = (int)a.ActivityTypeId!
                         })
                    })
                });

            XC.INF("The get all method (course) was successful");
            return await dto.ToListAsync();
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            if (_context.Course == null)
            {
                XC.ERR("No courses were found");
                return NotFound("No courses were found");
            }

            var course = await _context.Course.FindAsync(id);

            if (course == null)
            {
                XC.ERR("The course was not found");
                return NotFound("The course was not found");
            }

            XC.INF("The get one method (course) was successful");
            return course;
        }

        // PUT: api/Courses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            if (id != course.Id)
            {
                XC.ERR("The course and the corresponding id are different");
                return Problem("The course and the corresponding id are different");
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                XC.INF("The put method (course) was successful");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(id))
                {
                    XC.ERR("The course while saving was not found");
                    return NotFound("The course while saving was not found");
                }
                else
                {
                    XC.ERR("Cannot save (course)");
                    return Problem("Cannot save (course)");
                }
            }

            return NoContent();
        }

        // POST: api/Courses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
          if (_context.Course == null)
          {
                XC.ERR("Entity set 'ApplicationDbContext.Course' is null");
                return Problem("Entity set 'ApplicationDbContext.Course' is null");
          }
            _context.Course.Add(course);
            await _context.SaveChangesAsync();

            XC.INF("The post method (course) was successful");
            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            if (_context.Course == null)
            {
                XC.ERR("No courses were found");
                return NotFound("No courses were found");
            }
            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                XC.ERR("The course was not found");
                return NotFound("The course was not found");
            }

            _context.Course.Remove(course);
            await _context.SaveChangesAsync();

            XC.INF("The delete method (course) was successful");
            return NoContent();
        }

        private bool CourseExists(int id)
        {
            return (_context.Course?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
