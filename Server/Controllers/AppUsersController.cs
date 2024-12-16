using Microsoft.AspNetCore.Mvc;
using LexiconLMSBlazor.Server.Data;
using LexiconLMSBlazor.Server.Models;
using Microsoft.AspNetCore.Identity;
using LexiconLMSBlazor.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

namespace LexiconLMSBlazor.Server.Controllers
{
    [Route("api/AppUser")]
    [ApiController]
    public class AppUsersController(ApplicationDbContext context, UserManager<ApplicationUser> UserManager,
    ILogger<OidcConfigurationController> logger) : ControllerBase
    {
        private readonly ApplicationDbContext _context = context;
        private readonly UserManager<ApplicationUser> _userman = UserManager;
        private readonly ILogger<OidcConfigurationController> _logger = logger;

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
                    var dto = new AppUserDto // Måste ligga inne i foren annars pekar dto på endast en minnesplats.
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber
                    };
                    if (user.CourseId is not null) dto.CourseId = (int)user.CourseId; else dto.CourseId = 0;
                    dto.UserRole = await UserRole(user); // Måste vara await pga Task<int>.
                    dtolist.Add(dto);
                }
            }
            else
            {
                XC.ERR("No users were found");
                return NotFound("No users were found");
            }

            XC.INF("The get all method (user) was successful");
            return dtolist; // Viktigt att ändra i AppUserDtoClient, att det är en lista som returneras.
        }

        // Av Björn Lindqvist.
        [HttpPut("{id}/{prefix}")]
        public async Task<IActionResult> PutPrefix(string id, int prefix) // Tilldelar en roll eller ett kurs-id.
        {
            if (id == null || _context.Users == null)
            {
                XC.ERR("No users were found or id is null");
                return NotFound("No users were found or id is null");
            }

            var appUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);

            if (appUser == null)
            {
                XC.ERR("The user was not found");
                return NotFound("The user was not found");
            }

            if (prefix == 12) await _userman.RemoveFromRoleAsync(appUser, "Student"); // Tar bort rollen.

            if (prefix == 11) await _userman.RemoveFromRoleAsync(appUser, "Teacher"); // Tar bort rollen.

            if (prefix == 1 || prefix == 11) await _userman.AddToRoleAsync(appUser, "Student"); // Lägger till studentrollen. 

            if (prefix == 2 || prefix == 12) await _userman.AddToRoleAsync(appUser, "Teacher"); // Lägger till lärarrollen.

            if (prefix > 100) appUser.CourseId = prefix - 100; // Lägger till ett kurs-id.

            if (prefix == 100) appUser.CourseId = null; // Frilägger användaren från alla kurser.

            if (prefix > 0) await _context.SaveChangesAsync(); // Sparar.

            XC.INF("The put method (user) was successful");
            return NoContent();
        }

        // Av Björn Lindqvist
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id) // Tar bort en användare från systemet.
        {
            if (id == null || _context.Users == null)
            {
                XC.ERR("No users were found or id is null");
                return NotFound("No users were found or id is null");
            }

            var appUser = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);

            if (appUser == null)
            {
                XC.ERR("The user was not found");
                return NotFound("The user was not found");
            }

            var result = await _userman.DeleteAsync(appUser); // Koden är samma som den som raderar en användare i Areas.
            var userId = await _userman.GetUserIdAsync(appUser);

            if (userId == null)
            {
                XC.ERR("The user was not found");
                return NotFound("The user was not found");
            }

            if (!result.Succeeded)
            {
                XC.ERR("Unexpected error occurred deleting user");
                throw new InvalidOperationException("Unexpected error occurred deleting user");
            };

            XC.INF($"User with ID '{userId}' deleted themselves");
            _logger.LogInformation("User with ID '{userId}' deleted themselves", userId); // ILogger används här.
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
