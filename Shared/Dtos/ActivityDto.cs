using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Shared.Dtos
{
    public class ActivityDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = DateTime.Now;

        public byte Select { get; set; } = 1;

        // Foreign Keys
        public int ModuleId { get; set; }
        public int ActivityTypeId { get; set; }

        public string ActivityTypeName { get; set; } = string.Empty;
    }
}

