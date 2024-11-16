using Blazored.LocalStorage;
using LexiconLMSBlazor.Client.Services;
using LexiconLMSBlazor.Shared.Dtos;
using Microsoft.JSInterop;

public class XPagination : XDtoClient
{
    private readonly XNavMenu _nav;

    public XPagination(HttpClient httpClient, ILocalStorageService localStorageService,
    IJSRuntime jS, XNavMenu xnav) : base(httpClient, localStorageService, jS)
    {
        _nav = xnav;
    }

    public bool PagOn { get; set; } // On/Off.

    public bool PagAuto { get; set; } // Auto On/Off.

    public byte PagId { get; set; } // Identitetsnr.

    public int PagCount { get; set; } // Antal forloopar.

    public int PagRows { get; set; } // Satta rader.

    public int PagRed { get; set; } // Reduceringstal.

    public int PagPage { get; set; } // Vald sida.

    public string ClassPag { get; set; } = "d-flex"; // display:flex.

    private async Task LoadPag()  // Sparade värden i LocalStorage.
    {
        try
        {
            PagOn = bool.Parse(await GetStorage<string>($"Pag{PagId}On"));
            PagAuto = bool.Parse(await GetStorage<string>($"Pag{PagId}Auto"));
            PagRows = int.Parse(await GetStorage<string>($"Pag{PagId}Rows"));
            PagRed = int.Parse(await GetStorage<string>($"Pag{PagId}Red"));
            PagCount = 0;
            PagPage = 1;
            ClassPag = "d-flex";
        }
        catch
        {
            _nav.SetError("An error occurred while trying to open local storage.");
            _nav.SetReset('e');
            DefaultOut(false);
        }
    }

    private void DefaultOut(bool zero) // Om LS inte är tillgänglig.
    {
        PagOn = false;
        PagAuto = true;
        PagCount = 0;
        PagRows = 12; // Noll ger "division by zero"
        PagRed = 1; // Noll ger "division by zero"
        PagPage = 1;
        ClassPag = "d-flex";

        if (zero) PagOn = true;
    }

    public async Task InitPag(byte id, List<AppUserDto> xuser)
    {
        PagId = id; // Identitetsnummer för LocalStorage.

        if (PagId != 0) // Ett heltal större än 0 innebär: tillgång till panel.
        {
            if (PagRows == 0 || PagRed == 0 || xuser.Count < 1) await LoadPag();
            else
            {
                if (!Auxx.Flag) ClassPag = "d-none"; // Förhindrar att knapparna synliggörs.
                Auxx.Flag = false;
            }
        }

        if (PagId == 0) // PagId = 0 innebär: automatisk inställning (default-värden).
        {
            if (PagRows == 0 || PagRed == 0 || xuser.Count < 1) DefaultOut(true);
            else
            {
                if (!Auxx.Flag) ClassPag = "d-none"; // Förhindrar att knapparna synliggörs.
                Auxx.Flag = false;
            }
        }
    }

    public bool PagProceed(List<AppUserDto> xuser) // Omfattas av paginering.
    {
        bool Proceed = false;

        // Om man söker ett objekt på en sida med ett högt nummer.
        if (PagPage > (int)Math.Ceiling((decimal)xuser.Count / PagRows)) PagPage = 1;

        // Om paginering är OFF ELLER Antal forloopar >= Satta rader * (Vald sida - 1) OCH Antal forloopar < Satta rader * Vald sida, så ska tabeller räknas upp...
        if ((PagCount >= PagRows * (PagPage - 1) && PagCount < PagRows * PagPage) || !PagOn) Proceed = true;

        return Proceed;
    }

    public void PagBtnSet(int page, int pnum) // Uppdaterar vald sida och knappset.
    {
        if (page < 1) page = 1; // Förhindrar 0-sidor och sidor högre än förekommande.
        if (page > pnum && pnum != 0) page = pnum;

        PagPage = page;
        ClassPag = "d-none";
    }
}
