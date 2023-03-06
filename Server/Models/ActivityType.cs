using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconLMSBlazor.Server.Models
{
    public class ActivityType
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; } = string.Empty;

    }
}
