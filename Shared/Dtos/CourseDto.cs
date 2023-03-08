using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconLMSBlazor.Shared.Dtos
{
    public class CourseDto
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

        // Enumerable Type
        public ICollection<Module> Modules { get; set; } = new List<Module>();

        //public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}

