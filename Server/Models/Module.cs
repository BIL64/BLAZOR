using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconLMSBlazor.Server.Models
{
    public class Module
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

        // Foreign Key
        public int? CourseId { get; set; }

        // Enumerable Type
        public ICollection<Activity> Activities { get; set; } = new List<Activity>();
    }
}
