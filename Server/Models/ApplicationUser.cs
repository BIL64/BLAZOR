using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        // Foreign Key
        public int? CourseId { get; set; }

        // Enumerable Type
        public Course? Course { get; set; }
    }
}