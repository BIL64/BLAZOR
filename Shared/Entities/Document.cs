using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconLMSBlazor.Shared.Entities
{
    public class Document
    {
        public int Id { get; set; }

        [Required]
        public string DocName { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Timestamp]
        public byte[] TimeStamp { get; set; }

        [Required]
        public string Link { get; set; } = string.Empty;

        // Foreign Keys
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int ModuleId { get; set; }
        public int ActivityId { get; set; }
    }
}
