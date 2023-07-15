using Microsoft.AspNetCore.Components.Web;

public class XNavMenu // Klass som kan kommunicera med navmenyn.
{
    public bool JohnDoe { get; private set; } = true;

    public string ClassInfoMess { get; private set; } = "d-none";

    public string InfoMess { get; private set; } = string.Empty;

    public string ClassMessMess { get; private set; } = "d-none";

    public string MessMess { get; private set; } = string.Empty;

    public string ClassDoneMess { get; private set; } = "d-none";

    public string DoneMess { get; private set; } = string.Empty;

    public string ClassErrorMess { get; private set; } = "d-none";

    public string ErrorMess { get; private set; } = string.Empty;

    public string ClassAvatarMess { get; private set; } = "d-none"; // Class for avatar.

    public string PathImgMess { get; set; } = string.Empty; // Path to avatar.

    public string ClassAvatarLog { get; private set; } = "d-none"; // Class for log avatar.

    public string PathImgLog { get; set; } = string.Empty; // Path to log avatar.

    public string? ClassReg { get; set; } // show or hide.

    public string? ClassRegStatus { get; set; } // regon or regoff.

    public string? RegText { get; set; } // REG ON or REG OFF.

    public int Pos_H { get; set; } // Moveable Toaster.

    public int Pos_V { get; set; } // Moveable Toaster.

    private static bool IsDown; // Moveable Toaster.

    private static int Diff_X; // Moveable Toaster.

    private static int Diff_Y; // Moveable Toaster.

    public event Action? OnChange;

    public void SetJohnDoe(bool jd)
    {
        JohnDoe = jd;
        NotifyStateChanged();
    }

    public void SetInfo(string info)
    {
        ClassInfoMess = "xnavinfo";
        InfoMess = info;
        NotifyStateChanged();
    }

    public void SetMess(string mess)
    {
        ClassMessMess = "xnavmess";
        MessMess = mess;
        NotifyStateChanged();
    }

    public void SetDone(string done)
    {
        ClassDoneMess = "xnavdone";
        DoneMess = done;
        NotifyStateChanged();
    }

    public void SetError(string error)
    {
        ClassErrorMess = "xnaverror";
        ErrorMess = error;
        NotifyStateChanged();
    }

    public void SetReg(bool onoff)
    {
        if (onoff)
        {
            ClassRegStatus = "regon";
            RegText = "REG ON";
        }
        else
        {
            ClassRegStatus = "regoff";
            RegText = "REG OFF";
        }
        NotifyStateChanged();
    }

    public void SetReset(char ch)
    { 
        switch (ch)
        {
            case 'i':
            case 'I':
                {
                    ClassMessMess = "d-none";
                    ClassDoneMess = "d-none";
                    ClassErrorMess = "d-none";
                    ClassAvatarMess = "d-none";
                    MessMess = string.Empty;
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'm':
            case 'M':
                {
                    ClassInfoMess = "d-none";
                    ClassDoneMess = "d-none";
                    ClassErrorMess = "d-none";
                    ClassAvatarMess = "d-none";
                    InfoMess = string.Empty;
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'd':
            case 'D':
                {
                    ClassInfoMess = "d-none";
                    ClassMessMess = "d-none";
                    ClassErrorMess = "d-none";
                    ClassAvatarMess = "d-none";
                    InfoMess = string.Empty;
                    MessMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'e':
            case 'E':
                {
                    ClassInfoMess = "d-none";
                    ClassMessMess = "d-none";
                    ClassDoneMess = "d-none";
                    ClassAvatarMess = "d-none";
                    InfoMess = string.Empty;
                    MessMess = string.Empty;
                    DoneMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'v':
            case 'V':
                {
                    ClassInfoMess = "d-none";
                    ClassMessMess = "d-none";
                    ClassDoneMess = "d-none";
                    ClassErrorMess = "d-none";
                    InfoMess = string.Empty;
                    MessMess = string.Empty;
                    DoneMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            default:
                {
                    ClassInfoMess = "d-none";
                    ClassMessMess = "d-none";
                    ClassDoneMess = "d-none";
                    ClassErrorMess = "d-none";
                    ClassAvatarMess = "d-none";
                    InfoMess = string.Empty;
                    MessMess = string.Empty;
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
        }
    
    }

    public void SetLogAvatar(string classx, string path)
    {
        ClassAvatarLog = classx;
        PathImgLog = path;
        NotifyStateChanged();
    }

    public void SetMessAvatar(string classx, string path)
    {
        ClassAvatarMess = classx;
        PathImgMess = path;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();

    // ---------------------------------------------------------------
    // Här har jag lagt andra funktioner som förekommer mer än en gång
    // ---------------------------------------------------------------

    public static string StartEndDate(DateTime start, DateTime end) // Returnerar datumsträng.
    {
        return $"{start.ToString()[..10]} | {end.ToString()[..10]}";
    }

    public async Task Intermission(int time, bool hide) // Paus.
    {
        if (hide) SetReset('a');
        await Task.Delay(time);
    }

    public void Mouse(int height, char act, MouseEventArgs e) // Moveable Toaster.
    {
        if (!IsDown && act == 'D') // Skillnaden mellan muspekarens position och css-värdet av objektet.
        {
            Diff_X = (int)e.ClientX - Pos_H;
            Diff_Y = height - (Pos_V + (int)e.ClientY);
            IsDown = true;
        }

        if (IsDown && act == 'M') // Flyttar objektet asynkront i musens riktning.
        {
            if ((int)e.ClientX - Diff_X > 0) Pos_H = (int)e.ClientX - Diff_X; else Pos_H = 0;
            if (height - ((int)e.ClientY + Diff_Y) > 0) Pos_V = height - ((int)e.ClientY + Diff_Y); else Pos_V = 0;
        }

        if (act == 'U') IsDown = false; // När man släpper musknappen.
    }
}