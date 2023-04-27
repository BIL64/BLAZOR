// Av Björn Lindqvist
using LexiconLMSBlazor.Shared.Dtos;

public static class Auxx // Statisk klass med variabler som är åtkomliga överallt (nästan).
{
    public static string GuidId { get; set; } = string.Empty;

    public static int IntId { get; set; }

    public static int CourseId { get; set; }

    public static bool Flag { get; set; } // Olika syften.

    public static byte DocType { get; set; } // 1=User, 2=Course, 3=Module, 4=Activity.

    public static string Name4Type { get; set; } = string.Empty; // Namnet på typen.

    public static List<DocumentDto> documents { get; set; } = new List<DocumentDto>();

    public static bool PagOn { get; set; } // Paginering - On/Off.

    public static byte PagId { get; set; } // Paginering - Identitetsnr.

    public static int PagCount { get; set; } // Paginering - Antal forloopar.

    public static int PagRows { get; set; } // Paginering - Satta rader.

    public static int PagRed { get; set; } // Paginering - Reduceringstal.

    public static int PagPage { get; set; } // Paginering - Antal sidor.

    public static string classPag { get; set; } = "d-flex"; // Paginering - display:flex.
}
