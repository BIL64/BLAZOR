using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Server.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool HideDate { get; set; }

        // Enumerable Types
        public ICollection<Module> Modules { get; set; } = [];
        public ICollection<ApplicationUser> Users { get; set; } = [];
    }
}

