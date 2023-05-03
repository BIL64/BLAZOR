public class XNavMenu // Klass som kan kommunicera med navmenyn.
{
    public string classInfoMess { get; private set; } = "d-none";

    public string InfoMess { get; private set; } = string.Empty;

    public string classMessMess { get; private set; } = "d-none";

    public string MessMess { get; private set; } = string.Empty;

    public string classDoneMess { get; private set; } = "d-none";

    public string DoneMess { get; private set; } = string.Empty;

    public string classErrorMess { get; private set; } = "d-none";

    public string ErrorMess { get; private set; } = string.Empty;

    public string? classReg { get; set; } // show or hide.

    public string? classRegStatus { get; set; } // regon or regoff.

    public string? RegText { get; set; } // REG ON or REG OFF.

    public event Action? OnChange;

    public void SetInfo(string classx, string info)
    {
        classInfoMess = classx;
        InfoMess = info;
        NotifyStateChanged();
    }

    public void SetMess(string classx, string mess)
    {
        classMessMess = classx;
        MessMess = mess;
        NotifyStateChanged();
    }

    public void SetDone(string classx, string done)
    {
        classDoneMess = classx;
        DoneMess = done;
        NotifyStateChanged();
    }

    public void SetError(string classx, string error)
    {
        classErrorMess = classx;
        ErrorMess = error;
        NotifyStateChanged();
    }

    public void SetReg(bool onoff)
    {
        if (onoff)
        {
            classRegStatus = "regon";
            RegText = "REG ON";
        }
        else
        {
            classRegStatus = "regoff";
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
                    classMessMess = "d-none";
                    classDoneMess = "d-none";
                    classErrorMess = "d-none";
                    MessMess = string.Empty;
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'm':
            case 'M':
                {
                    classInfoMess = "d-none";
                    classDoneMess = "d-none";
                    classErrorMess = "d-none";
                    InfoMess = string.Empty;
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'd':
            case 'D':
                {
                    classInfoMess = "d-none";
                    classMessMess = "d-none";
                    classErrorMess = "d-none";
                    InfoMess = string.Empty;
                    MessMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'e':
            case 'E':
                {
                    classInfoMess = "d-none";
                    classMessMess = "d-none";
                    classDoneMess = "d-none";
                    InfoMess = string.Empty;
                    MessMess = string.Empty;
                    DoneMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            default:
                {
                    classInfoMess = "d-none";
                    classMessMess = "d-none";
                    classDoneMess = "d-none";
                    classErrorMess = "d-none";
                    InfoMess = string.Empty;
                    MessMess = string.Empty;
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
        }
    
    }
    private void NotifyStateChanged() => OnChange?.Invoke();
}