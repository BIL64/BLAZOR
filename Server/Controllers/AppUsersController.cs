using Microsoft.AspNetCore.Mvc;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Identity;
using LexiconLMSBlazor.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Humanizer;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/AppUser")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userman;
        private readonly ILogger<OidcConfigurationController> _logger;

        public AppUsersController(ApplicationDbContext context, UserManager<ApplicationUser> UserManager, ILogger<OidcConfigurationController> logger)
        {
            _context = context;
            this._userman = UserManager;
            this._logger = logger;
        }

        // Av Björn Lindqvist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUserDto>>> GetAppUser()
        {
            var appuser = _context.Users;
            var dtolist = new List<AppUserDto>();

            if (appuser is not null)
            {
                foreach (var user in appuser) // LINQ fungerar inte eftersom LINQ inte kan await Task<int>.
                {
                    var dto = new AppUserDto(); // Måste ligga inne i foren annars pekar dto på endast en minnesplats.
                    dto.Id = user.Id;
                    dto.FirstName = user.FirstName;
                    dto.LastName = user.LastName;
                    dto.Email = user.Email;
                    if (user.CourseId is not null) dto.CourseId = (int)user.CourseId; else dto.CourseId = 0;
                    dto.UserRole = await UserRole(user); // Måste vara await pga Task<int>.
                    dtolist.Add(dto);
                }
            }

            return dtolist; // Viktigt att ändra i AppUserDtoClient, att det är en lista som returneras.
        }

        // Av Björn Lindqvist.
        [HttpPut("{id}/{prefix}")]
        public async Task<IActionResult> PutPrefix(string id, int prefix) // Tilldelar en roll eller ett kurs-id.
        {
            if (id == null || _context.Users == null)
            {
                return BadRequest();
            }

            var appUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);

            if (appUser == null) return BadRequest();

            if (prefix == 12) await _userman.RemoveFromRoleAsync(appUser, "Student"); // Tar bort rollen.

            if (prefix == 11) await _userman.RemoveFromRoleAsync(appUser, "Teacher"); // Tar bort rollen.

            if (prefix == 1 || prefix == 11) await _userman.AddToRoleAsync(appUser, "Student"); // Lägger till studentrollen. 

            if (prefix == 2 || prefix == 12) await _userman.AddToRoleAsync(appUser, "Teacher"); // Lägger till lärarrollen.

            if (prefix > 100) appUser.CourseId = prefix - 100; // Lägger till ett kurs-id.

            if (prefix > 0) await _context.SaveChangesAsync(); // Sparar.

            return NoContent();
        }

        // Av Björn Lindqvist
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id) // Tar bort en användare från systemet.
        {
            if (id == null || _context.Users == null)
            {
                return BadRequest();
            }

            var appUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);

            if (appUser == null) return BadRequest();

            var result = await _userman.DeleteAsync(appUser); // Koden är samma som den som raderar en användare i Areas.
            var userId = await _userman.GetUserIdAsync(appUser);

            if (userId == null) return BadRequest();

            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Unexpected error occurred deleting user.");
            };

            _logger.LogInformation("User with ID '{UserId}' deleted themselves.", userId); // ILogger används här.

            return NoContent();
        }

        // Av Björn Lindqvist
        private async Task<int> UserRole(ApplicationUser appUser) // Returnerar alla användares roller.
        {
            int roleId = 0;
            var roles = await _userman.GetRolesAsync(appUser); // Måste vara await.

            if (roles is not null)
            {
                foreach (var role in roles) // Det är "role" som är själva strängen och som då är inbakad i "roles".
                {
                    if (role is not null)
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
