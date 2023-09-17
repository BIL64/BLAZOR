using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Server.Models
{
    public class Activity
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

        public byte Select { get; set; } = 1;

        // Foreign Keys
        public int? ModuleId { get; set; }
        public int? ActivityTypeId { get; set; }
    }
}
