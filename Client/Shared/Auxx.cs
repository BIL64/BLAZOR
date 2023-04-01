// Av Björn Lindqvist
public static class Auxx // Statisk klass med variabler som är åtkomliga överallt (nästan).
{
    public static string GuidId { get; set; } = string.Empty;

    public static int IntId { get; set; }

    public static int CourseId { get; set; }

    public static bool DelFlag { get; set; }

    public static bool PagOn { get; set; } // Paginering.

    public static int PagCount { get; set; } // Paginering.

    public static int PagRows { get; set; } // Paginering.

    public static int PagPage { get; set; } // Paginering.

    public static string classPag = "dflex"; // Paginering.
}
