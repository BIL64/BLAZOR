public class XLangEdit // Implementerar det språk man valt via Local Storage.
{
    public string RenderPage { get; set; } = string.Empty;

    public string[] TxtButton { get; private set; } = new string[6];

    public string[] TxtTitle { get; private set; } = new string[10];

    public string[] TxtText { get; private set; } = new string[30];

    public event Action? OnChange;

    private void Button_EN()
    {
        int i = 0;

        // 0
        TxtButton[i] = "Return";
        i++;
        // 1
        TxtButton[i] = "Save";
        i++;
        // 2
        TxtButton[i] = "Add module";
        i++;
        // 3
        TxtButton[i] = "Delete module";
        i++;
        // 4
        TxtButton[i] = "Delete immediately!";
        i++;
        // 5
        TxtButton[i] = "Add activity";
    }

    private void Button_SV()
    {
        int i = 0;

        // 0
        TxtButton[i] = "Gå tillbaka";
        i++;
        // 1
        TxtButton[i] = "Spara";
        i++;
        // 2
        TxtButton[i] = "Lägg till modul";
        i++;
        // 3
        TxtButton[i] = "Radera modul";
        i++;
        // 4
        TxtButton[i] = "Radera omedelbart!";
        i++;
        // 5
        TxtButton[i] = "Lägg till aktivitet";
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
        TxtTitle[i] = "Avoid edit course";
        i++;
        // 2
        TxtTitle[i] = "Avoid edit module";
        i++;
        // 3
        TxtTitle[i] = "Avoid edit activity";
        i++;
        // 4
        TxtTitle[i] = "Save this edit form";
        i++;
        // 5
        TxtTitle[i] = "Add this module with one blank activity";
        i++;
        // 6
        TxtTitle[i] = "Add this activity";
        i++;
        // 7
        TxtTitle[i] = "Remove this module, all activities, and all its documents";
        i++;
        // 8
        TxtTitle[i] = "Remove this activity and all its documents from the system";
        i++;
        // 9
        TxtTitle[i] = "Eliminate all non-mandatory documents and messages from the system";
    }

    private void Title_SV()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "reserve";
        i++;
        // 1
        TxtTitle[i] = "Ångra redigera kurs";
        i++;
        // 2
        TxtTitle[i] = "Ångra redigera modul";
        i++;
        // 3
        TxtTitle[i] = "Ångra redigera aktivitet";
        i++;
        // 4
        TxtTitle[i] = "Spara detta redigerade formulär";
        i++;
        // 5
        TxtTitle[i] = "Lägg till den här modulen med en tom aktivitet";
        i++;
        // 6
        TxtTitle[i] = "Lägg till denna aktivitet";
        i++;
        // 7
        TxtTitle[i] = "Ta bort den här modulen, alla aktiviteter och alla dess dokument";
        i++;
        // 8
        TxtTitle[i] = "Ta bort den här aktiviteten och alla dess dokument från systemet";
        i++;
        // 9
        TxtTitle[i] = "Eliminera alla icke obligatoriska dokument och meddelanden från systemet";
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
        TxtText[i] = "Edit course:";
        i++;
        // 2
        TxtText[i] = "Edit, add, or delete module:";
        i++;
        // 3
        TxtText[i] = "Edit, add, or delete activity:";
        i++;
        // 4
        TxtText[i] = "Name";
        i++;
        // 5
        TxtText[i] = "Description";
        i++;
        // 6
        TxtText[i] = "Start date";
        i++;
        // 7
        TxtText[i] = "End date";
        i++;
        // 8
        TxtText[i] = "Type";
        i++;
        // 9
        TxtText[i] = "This form was NOT edited or created.";
        i++;
        // 10
        TxtText[i] = "This course was edited.";
        i++;
        // 11
        TxtText[i] = "reserve";
        i++;
        // 12
        TxtText[i] = "reserve";
        i++;
        // 13
        TxtText[i] = "reserve";
        i++;
        // 14
        TxtText[i] = "This form was edited or added.";
        i++;
        // 15
        TxtText[i] = "This activity and all its documents were deleted.";
        i++;
        // 16
        TxtText[i] = "Date mismatch (start date is greater than end date).";
        i++;
        // 17
        TxtText[i] = "COURSE:";
        i++;
        // 18
        TxtText[i] = "Modules...";
        i++;
        // 19
        TxtText[i] = "Activities for module";
        i++;
        // 20
        TxtText[i] = "reserve";
        i++;
        // 21
        TxtText[i] = "reserve";
        i++;
        // 22
        TxtText[i] = "reserve";
        i++;
        // 23
        TxtText[i] = "Module name";
        i++;
        // 24
        TxtText[i] = "Module description";
        i++;
        // 25
        TxtText[i] = "Module date";
        i++;
        // 26
        TxtText[i] = "Activity name";
        i++;
        // 27
        TxtText[i] = "Activity type";
        i++;
        // 28
        TxtText[i] = "Activity description";
        i++;
        // 29
        TxtText[i] = "Activity date";
    }

    private void Text_SV()
    {
        int i = 0;

        // 0
        TxtText[i] = "reserve";
        i++;
        // 1
        TxtText[i] = "Redigera kurs:";
        i++;
        // 2
        TxtText[i] = "Redigera, lägg till eller ta bort modul:";
        i++;
        // 3
        TxtText[i] = "Redigera, lägg till eller ta bort aktivitet:";
        i++;
        // 4
        TxtText[i] = "Namn";
        i++;
        // 5
        TxtText[i] = "Beskrivning";
        i++;
        // 6
        TxtText[i] = "Startdatum";
        i++;
        // 7
        TxtText[i] = "Slutdatum";
        i++;
        // 8
        TxtText[i] = "Typ";
        i++;
        // 9
        TxtText[i] = "Detta formulär har INTE redigerats eller skapats.";
        i++;
        // 10
        TxtText[i] = "Denna kurs har redigerats.";
        i++;
        // 11
        TxtText[i] = "reserve";
        i++;
        // 12
        TxtText[i] = "reserve";
        i++;
        // 13
        TxtText[i] = "reserve";
        i++;
        // 14
        TxtText[i] = "Detta formulär har redigerats eller lagts till.";
        i++;
        // 15
        TxtText[i] = "Denna aktivitet och alla dess dokument raderades.";
        i++;
        // 16
        TxtText[i] = "Datumfel (startdatumet är större än slutdatumet).";
        i++;
        // 17
        TxtText[i] = "KURS:";
        i++;
        // 18
        TxtText[i] = "Moduler...";
        i++;
        // 19
        TxtText[i] = "Aktiviteter för module";
        i++;
        // 20
        TxtText[i] = "reserve";
        i++;
        // 21
        TxtText[i] = "reserve";
        i++;
        // 22
        TxtText[i] = "reserve";
        i++;
        // 23
        TxtText[i] = "Modulnamn";
        i++;
        // 24
        TxtText[i] = "Modulbeskrivning";
        i++;
        // 25
        TxtText[i] = "Moduldatum";
        i++;
        // 26
        TxtText[i] = "Aktivitetsnamn";
        i++;
        // 27
        TxtText[i] = "Aktivitetstyp";
        i++;
        // 28
        TxtText[i] = "Aktivitetsbeskrivning";
        i++;
        // 29
        TxtText[i] = "Aktivitetsdatum";
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
        RenderPage = "STILL_HERE";
        Button_EN();
        Title_EN();
        Text_EN();
        NotifyStateChanged();
    }

    public void SetLanguage_SV()
    {
        RenderPage = "STILL_HERE";
        Button_SV();
        Title_SV();
        Text_SV();
        NotifyStateChanged();
    }

    public void SetLanguage_DE()
    {
        RenderPage = "STILL_HERE";
        Button_DE();
        Title_DE();
        Text_DE();
        NotifyStateChanged();
    }

    public void SetLanguage_FR()
    {
        RenderPage = "STILL_HERE";
        Button_FR();
        Title_FR();
        Text_FR();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}