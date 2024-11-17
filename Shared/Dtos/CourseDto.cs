using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Shared.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = DateTime.Now;

        // Enumerable Type
        public IEnumerable<ModuleDto> Modules { get; set; } = [];

        public int Total_M { get; set; } // Antal moduler.

        public int Total_S { get; set; } // Antal studenter.

        public int Total_D { get; set; } // Antal dokument.
    }
}

