using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Shared.Dtos
{
    public class ModuleDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        public int CourseId { get; set; }

        public IEnumerable<ActivityDto> Activities { get; set; } = new List<ActivityDto>();
    }
}

