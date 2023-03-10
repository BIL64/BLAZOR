using Microsoft.AspNetCore.Mvc;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Identity;
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/AppUser")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userman;
        public AppUserController(ApplicationDbContext context, UserManager<ApplicationUser> UserManager)
        {
            _context = context;
            this._userman = UserManager;
        }

        // GET: api/Activities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUserDto>>> GetAppUser()
        {
            var appuser = _context.Users;            
            var dtolist = new List<AppUserDto>();

            foreach (var user in appuser) // LINQ fungerar inte eftersom LINQ inte kan await Task<int>.
            {
                var dto = new AppUserDto(); // Måste ligga inne i foren annars pekar dto på endast en minnesplats.
                dto.Id = user.Id;
                dto.FirstName = user.FirstName;
                dto.LastName = user.LastName;
                dto.Email = user.Email;
                if (user.Course is not null) dto.CourseName = user.Course.Name; else dto.CourseName = "No course yet...";
                dto.UserRole = await UserRole(user); // Måste vara await pga Task<int>.
                dtolist.Add(dto);
            }

            return dtolist;
        }

        private async Task<int> UserRole(ApplicationUser appUser) // Returnerar alla användares roller.
        {
            int roleId = 0;
            var roles = await _userman.GetRolesAsync(appUser); // Måste vara await.

            if (roles != null)
            {
                foreach (var role in roles) // Det är "role" som är själva strängen och som då är inbakad i "roles".
                {
                    if (role != null)
                    {
                        if (role == "Student") roleId = 1; // Sätts manuellt.
                        if (role == "Teacher") roleId = 2;
                    }
                }
            }
            return roleId;
        }
    }
}
