using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Shared.Dtos
{
    public class DocumentDto
    {
        public int Id { get; set; }

        public int NameIx { get; set; }

        public string DocName { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        public string TimeStamp { get; set; } = string.Empty;

        public int Id4Course { get; set; }

        // Foreign Keys
        public string UserId { get; set; } = string.Empty;
        public int ModuleId { get; set; }
        public int ActivityId { get; set; }
    }
}
