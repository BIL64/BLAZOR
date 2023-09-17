using System.ComponentModel.DataAnnotations;

namespace LexiconLMSBlazor.Server.Models
{
    public class Forum
    {
        public int Id { get; set; }

        [Required]
        public string ThreadName { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Text { get; set; } = string.Empty;

        public string AuxHead { get; set; } = string.Empty; // Tilläggsrubrik.

        public string? Id4User { get; set; } // Skribent (debattör).

        public int Edited { get; set; } = 0; // Antal redigeringar.

        public string Pmail { get; set; } = string.Empty; // För privata trådar.

        public bool IsMan { get; set; } = false; // Obligatorisk tråd.

        public byte Select { get; set; } // 0=initieringspost, 1=lärare, 2=elev, 11=censurerad lärare, 22=censurerad elev.

        public int Id4Course { get; set; } // Kurs-id om obligatorisk.
    }
}
