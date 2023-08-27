public class XLangToastEdit // Implementerar det språk man valt via Local Storage.
{
    public string[] TxtButton { get; private set; } = new string[4];

    public string[] TxtTitle { get; private set; } = new string[5];

    public string[] TxtText { get; private set; } = new string[8];

    public event Action? OnChange;

    private void Button_EN()
    {
        int i = 0;

        // 0
        TxtButton[i] = "NO";
        i++;
        // 1
        TxtButton[i] = "YES";
        i++;
        // 2
        TxtButton[i] = "DELETE NOW";
        i++;
        // 3
        TxtButton[i] = "Save";
    }

    private void Button_SV()
    {
        int i = 0;

        // 0
        TxtButton[i] = "NEJ";
        i++;
        // 1
        TxtButton[i] = "JA";
        i++;
        // 2
        TxtButton[i] = "RADERA NU";
        i++;
        // 3
        TxtButton[i] = "Spara";
    }

    private void Button_DE()
    {
        // Deutsch
    }

    private void Button_FR()
    {
        // Français
    }

    private void Title_EN()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "reserve";
        i++;
        // 1
        TxtTitle[i] = "Remove this module and all its activities from the system";
        i++;
        // 2
        TxtTitle[i] = "Remove all non-mandatory documents and messages from the system";
        i++;
        // 3
        TxtTitle[i] = "Today's date";
        i++;
        // 4
        TxtTitle[i] = "Save settings";
    }

    private void Title_SV()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "reserve";
        i++;
        // 1
        TxtTitle[i] = "Ta bort den här modulen och alla dess aktiviteter från systemet";
        i++;
        // 2
        TxtTitle[i] = "Ta bort alla icke-obligatoriska dokument och meddelanden från systemet";
        i++;
        // 3
        TxtTitle[i] = "Dagens datum";
        i++;
        // 4
        TxtTitle[i] = "Spara inställningarna";
    }

    private void Title_DE()
    {
        // Deutsch
    }

    private void Title_FR()
    {
        // Français
    }

    private void Text_EN()
    {
        int i = 0;

        // 0
        TxtText[i] = "reserve";
        i++;
        // 1
        TxtText[i] = "Remove this module...";
        i++;
        // 2
        TxtText[i] = "This module and all its documents and activities were deleted.";
        i++;
        // 3
        TxtText[i] = "Eliminate all non-mandatory docs and mess...";
        i++;
        // 4
        TxtText[i] = "Enter today's date (yyyy-mm-dd)";
        i++;
        // 5
        TxtText[i] = "All non-mandatory documents and messages were deleted.";
        i++;
        // 6
        TxtText[i] = "No documents or messages could be found.";
        i++;
        // 7
        TxtText[i] = "The date was incorrect.";
    }

    private void Text_SV()
    {
        int i = 0;

        // 0
        TxtText[i] = "reserve";
        i++;
        // 1
        TxtText[i] = "Ta bort den här modulen...";
        i++;
        // 2
        TxtText[i] = "Denna modul och alla dess dokument och aktiviteter raderades.";
        i++;
        // 3
        TxtText[i] = "Eliminera alla docs & mess från deltagare....";
        i++;
        // 4
        TxtText[i] = "Ange dagens datum (åååå-mm-dd)";
        i++;
        // 5
        TxtText[i] = "Alla icke-obligatoriska dokument och meddelanden raderades.";
        i++;
        // 6
        TxtText[i] = "Inga dokument eller meddelanden kunde hittas.";
        i++;
        // 7
        TxtText[i] = "Datumet var felaktigt.";
    }

    private void Text_DE()
    {
        // Deutsch
    }

    private void Text_FR()
    {
        // Français
    }

    public void SetLanguage_EN()
    {
        Button_EN();
        Title_EN();
        Text_EN();
        NotifyStateChanged();
    }

    public void SetLanguage_SV()
    {
        Button_SV();
        Title_SV();
        Text_SV();
        NotifyStateChanged();
    }

    public void SetLanguage_DE()
    {
        Button_DE();
        Title_DE();
        Text_DE();
        NotifyStateChanged();
    }

    public void SetLanguage_FR()
    {
        Button_FR();
        Title_FR();
        Text_FR();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}