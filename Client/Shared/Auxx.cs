// Av Björn Lindqvist
using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Client.Shared
{
    public static class Auxx // Statisk klass med variabler som är åtkomliga överallt (nästan).
    {
        public static string GuidId { get; set; } = string.Empty;

        public static int IntId { get; set; }

        public static int CourseId { get; set; }

        public static bool Flag { get; set; } // Olika syften.

        public static byte DocType { get; set; } // 1=User, 2=Course, 3=Module, 4=Activity.

        public static string Name4Type { get; set; } = string.Empty; // Namnet på typen.

        public static AppUserDto Loggeduser { get; set; } = new AppUserDto();

        public static List<DocumentDto> Documents { get; set; } = [];
    }
}