public class XLangStudent // Implementerar det språk man valt via Local Storage.
{
    public string RenderPage { get; set; } = string.Empty;

    public string[] TxtMenu { get; private set; } = new string[4];

    public string[] TxtTitle { get; private set; } = new string[6];

    public string[] TxtText { get; private set; } = new string[26];

    public event Action? OnChange;

    private void Menu_EN()
    {
        int i = 0;

        // 0
        TxtMenu[i] = "Home";
        i++;
        // 1
        TxtMenu[i] = "Your course";
        i++;
        // 2
        TxtMenu[i] = "Course participants";
        i++;
        // 3
        TxtMenu[i] = "S T U D E N T";
    }

    private void Menu_SV()
    {
        int i = 0;

        // 0
        TxtMenu[i] = "Hem";
        i++;
        // 1
        TxtMenu[i] = "Din kurs";
        i++;
        // 2
        TxtMenu[i] = "Kursdeltagare";
        i++;
        // 3
        TxtMenu[i] = "S T U D E N T";
    }

    private void Menu_DE()
    {
        // Deutsch
    }

    private void Menu_FR()
    {
        // Français
    }

    private void Title_EN()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "Add or delete avatar";
        i++;
        // 1
        TxtTitle[i] = "Eliminate all documents and messages";
        i++;
        // 2
        TxtTitle[i] = "Mandatory post";
        i++;
        // 3
        TxtTitle[i] = "Personal post";
        i++;
        // 4
        TxtTitle[i] = "Add a document or message to this activity";
        i++;
        // 5
        TxtTitle[i] = "Send a document or message to someone";
    }

    private void Title_SV()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "Lägg till eller radera avatar";
        i++;
        // 1
        TxtTitle[i] = "Eliminera alla dokument och meddelanden";
        i++;
        // 2
        TxtTitle[i] = "Obligatorisk post";
        i++;
        // 3
        TxtTitle[i] = "Personlig post";
        i++;
        // 4
        TxtTitle[i] = "Lägg till ett dokument eller meddelande till denna aktivitet";
        i++;
        // 5
        TxtTitle[i] = "Skicka ett dokument eller meddelande till någon";
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
        TxtText[i] = "this is your course:";
        i++;
        // 1
        TxtText[i] = "Module";
        i++;
        // 2
        TxtText[i] = "Nr";
        i++;
        // 3
        TxtText[i] = "Activity";
        i++;
        // 4
        TxtText[i] = "Description";
        i++;
        // 5
        TxtText[i] = "Type";
        i++;
        // 6
        TxtText[i] = "Date";
        i++;
        // 7
        TxtText[i] = "Appendix";
        i++;
        // 8
        TxtText[i] = "Participant";
        i++;
        // 9
        TxtText[i] = "Email";
        i++;
        // 10
        TxtText[i] = "Phone number";
        i++;
        // 11
        TxtText[i] = "Course";
        i++;
        // 12
        TxtText[i] = "List of participants";
        i++;
        // 13
        TxtText[i] = "No participants !";
        i++;
        // 14
        TxtText[i] = "There is no student or teacher with that name...";
        i++;
        // 15
        TxtText[i] = "(teacher)";
        i++;
        // 16
        TxtText[i] = "No course yet...";
        i++;
        // 17
        TxtText[i] = "The current module.";
        i++;
        // 18
        TxtText[i] = "There is no current module.";
        i++;
        // 19
        TxtText[i] = "No module matched the search term...";
        i++;
        // 20
        TxtText[i] = "No course could be find...";
        i++;
        // 21
        TxtText[i] = "Welcome to ";
        i++;
        // 22
        TxtText[i] = "images/Notes_EN.jpg";
        i++;
        // 23
        TxtText[i] = "Sheet";
        i++;
        // 24
        TxtText[i] = "of 3";
        i++;
        // 25
        TxtText[i] = "Save sheet";
    }

    private void Text_SV()
    {
        int i = 0;

        // 0
        TxtText[i] = "detta är din kurs:";
        i++;
        // 1
        TxtText[i] = "Modul";
        i++;
        // 2
        TxtText[i] = "Nr";
        i++;
        // 3
        TxtText[i] = "Aktivitet";
        i++;
        // 4
        TxtText[i] = "Beskrivning";
        i++;
        // 5
        TxtText[i] = "Typ";
        i++;
        // 6
        TxtText[i] = "Datum";
        i++;
        // 7
        TxtText[i] = "Appendix";
        i++;
        // 8
        TxtText[i] = "Deltagare";
        i++;
        // 9
        TxtText[i] = "E-post";
        i++;
        // 10
        TxtText[i] = "Telefonnummer";
        i++;
        // 11
        TxtText[i] = "Kurs";
        i++;
        // 12
        TxtText[i] = "Listning av deltagare";
        i++;
        // 13
        TxtText[i] = "Inga deltagare !";
        i++;
        // 14
        TxtText[i] = "Det finns ingen elev eller lärare med detta namn...";
        i++;
        // 15
        TxtText[i] = "(lärare)";
        i++;
        // 16
        TxtText[i] = "Ingen kurs ännu...";
        i++;
        // 17
        TxtText[i] = "Den aktuella modulen.";
        i++;
        // 18
        TxtText[i] = "Det finns ingen aktuell modul.";
        i++;
        // 19
        TxtText[i] = "Ingen modul motsvarar söktermen...";
        i++;
        // 20
        TxtText[i] = "Ingen kurs kan hittas...";
        i++;
        // 21
        TxtText[i] = "Välkommen till ";
        i++;
        // 22
        TxtText[i] = "images/Notes_SV.jpg";
        i++;
        // 23
        TxtText[i] = "Blad";
        i++;
        // 24
        TxtText[i] = "av 3";
        i++;
        // 25
        TxtText[i] = "Spara blad";
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
        Menu_EN();
        Title_EN();
        Text_EN();
        NotifyStateChanged();
    }

    public void SetLanguage_SV()
    {
        RenderPage = "STILL_HERE";
        Menu_SV();
        Title_SV();
        Text_SV();
        NotifyStateChanged();
    }

    public void SetLanguage_DE()
    {
        RenderPage = "STILL_HERE";
        Menu_DE();
        Title_DE();
        Text_DE();
        NotifyStateChanged();
    }

    public void SetLanguage_FR()
    {
        RenderPage = "STILL_HERE";
        Menu_FR();
        Title_FR();
        Text_FR();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}