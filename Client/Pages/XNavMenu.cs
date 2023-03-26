public class XNavMenu // Klass som kan kommunicera med navmenyn.
{
    public string classInfoMess { get; private set; } = "hide";

    public string InfoMess { get; private set; } = string.Empty;

    public string classDoneMess { get; private set; } = "hide";

    public string DoneMess { get; private set; } = string.Empty;

    public string classErrorMess { get; private set; } = "hide";

    public string ErrorMess { get; private set; } = string.Empty;

    public event Action? OnChange;

    public void SetInfo(string classx, string info)
    {
        classInfoMess = classx;
        InfoMess = info;
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

    public void SetReset(char ch)
    { 
        switch (ch)
        {
            case 'i':
            case 'I':
                {
                    classDoneMess = "hide";
                    classErrorMess = "hide";
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'd':
            case 'D':
                {
                    classInfoMess = "hide";
                    classErrorMess = "hide";
                    InfoMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            case 'e':
            case 'E':
                {
                    classInfoMess = "hide";
                    classDoneMess = "hide";
                    InfoMess = string.Empty;
                    DoneMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
            default:
                {
                    classInfoMess = "hide";
                    classDoneMess = "hide";
                    classErrorMess = "hide";
                    InfoMess = string.Empty;
                    DoneMess = string.Empty;
                    ErrorMess = string.Empty;
                    NotifyStateChanged();
                    break;
                }
        }
    
    }
    private void NotifyStateChanged() => OnChange?.Invoke();
}