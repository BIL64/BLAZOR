public class XNavMenu // Klass som kan kommunicera med navmenyn.
{
    public string classDoneMess { get; private set; } = "hide";

    public string DoneMess { get; private set; } = string.Empty;

    public string classErrorMess { get; private set; } = "hide";

    public string ErrorMess { get; private set; } = string.Empty;

    public event Action? OnChange;

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

    private void NotifyStateChanged() => OnChange?.Invoke();
}