public class XLangStudent // Implementerar det språk man valt via Local Storage.
{
    public string RenderPage { get; set; } = string.Empty;

    public string[] TxtMenu { get; private set; } = new string[5];

    public string[] TxtTitle { get; private set; } = new string[12];

    public string[] TxtText { get; private set; } = new string[59];

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
        TxtMenu[i] = "Forum";
        i++;
        // 4
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
        TxtMenu[i] = "Forum";
        i++;
        // 4
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
        i++;
        // 6
        TxtTitle[i] = "Mandatory thread";
        i++;
        // 7
        TxtTitle[i] = "Open this thread";
        i++;
        // 8
        TxtTitle[i] = "Save this thread to your system";
        i++;
        // 9
        TxtTitle[i] = "Edit this post";
        i++;
        // 10
        TxtTitle[i] = "Number of edits for this post";
        i++;
        // 11
        TxtTitle[i] = "Up again";
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
        i++;
        // 6
        TxtTitle[i] = "Obligatorisk tråd";
        i++;
        // 7
        TxtTitle[i] = "Öppna den här tråden";
        i++;
        // 8
        TxtTitle[i] = "Spara den här tråden i ditt system";
        i++;
        // 9
        TxtTitle[i] = "Redigera det här inlägget";
        i++;
        // 10
        TxtTitle[i] = "Antal redigeringar för detta inlägg";
        i++;
        // 11
        TxtTitle[i] = "Upp igen";
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
        i++;
        // 26
        TxtText[i] = "Add/edit thread";
        i++;
        // 27
        TxtText[i] = "Delete thread";
        i++;
        // 28
        TxtText[i] = "Close";
        i++;
        // 29
        TxtText[i] = "Save thread";
        i++;
        // 30
        TxtText[i] = "Post it!";
        i++;
        // 31
        TxtText[i] = "reserve";
        i++;
        // 32
        TxtText[i] = "reserve";
        i++;
        // 33
        TxtText[i] = "Your saved threads...";
        i++;
        // 34
        TxtText[i] = "This post has been deleted...";
        i++;
        // 35
        TxtText[i] = "Created by";
        i++;
        // 36
        TxtText[i] = " - Private";
        i++;
        // 37
        TxtText[i] = " - Mandatory";
        i++;
        // 38
        TxtText[i] = " - No restrictions";
        i++;
        // 39
        TxtText[i] = "Write a reply";
        i++;
        // 40
        TxtText[i] = "Add to the name (red)";
        i++;
        // 41
        TxtText[i] = "reserve";
        i++;
        // 42
        TxtText[i] = "reserve";
        i++;
        // 43
        TxtText[i] = "reserve";
        i++;
        // 44
        TxtText[i] = "Discussion forum";
        i++;
        // 45
        TxtText[i] = "Forum is missing...";
        i++;
        // 46
        TxtText[i] = "No threads could be found...";
        i++;
        // 47
        TxtText[i] = "The thread is saved.";
        i++;
        // 48
        TxtText[i] = "The thread is already saved.";
        i++;
        // 49
        TxtText[i] = "No content no post.";
        i++;
        // 50
        TxtText[i] = "You are not authorized to write in this thread.";
        i++;
        // 51
        TxtText[i] = "The thread cannot be found.";
        i++;
        // 52
        TxtText[i] = "reserve";
        i++;
        // 53
        TxtText[i] = "reserve";
        i++;
        // 54
        TxtText[i] = "reserve";
        i++;
        // 55
        TxtText[i] = "Thumbs UP for this.";
        i++;
        // 56
        TxtText[i] = "Thumbs down for this.";
        i++;
        // 57
        TxtText[i] = "You changed your mind.";
        i++;
        // 58
        TxtText[i] = "One is enough!";
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
        i++;
        // 26
        TxtText[i] = "Lägg till / redigera tråd";
        i++;
        // 27
        TxtText[i] = "Ta bort tråd";
        i++;
        // 28
        TxtText[i] = "Stäng";
        i++;
        // 29
        TxtText[i] = "Spara tråd";
        i++;
        // 30
        TxtText[i] = "Posta nu!";
        i++;
        // 31
        TxtText[i] = "reserve";
        i++;
        // 32
        TxtText[i] = "reserve";
        i++;
        // 33
        TxtText[i] = "Dina sparade trådar...";
        i++;
        // 34
        TxtText[i] = "Detta inlägg har tagits bort...";
        i++;
        // 35
        TxtText[i] = "Skapad av";
        i++;
        // 36
        TxtText[i] = " - Privat";
        i++;
        // 37
        TxtText[i] = " - Obligatorisk";
        i++;
        // 38
        TxtText[i] = " - Inga restriktioner";
        i++;
        // 39
        TxtText[i] = "Skriv ett inlägg";
        i++;
        // 40
        TxtText[i] = "Adderar till namnet (rött)";
        i++;
        // 41
        TxtText[i] = "reserve";
        i++;
        // 42
        TxtText[i] = "reserve";
        i++;
        // 43
        TxtText[i] = "reserve";
        i++;
        // 44
        TxtText[i] = "Diskussionsforum";
        i++;
        // 45
        TxtText[i] = "Forum saknas...";
        i++;
        // 46
        TxtText[i] = "Inga trådar kunde hittas...";
        i++;
        // 47
        TxtText[i] = "Tråden är sparad.";
        i++;
        // 48
        TxtText[i] = "Tråden är redan sparad.";
        i++;
        // 49
        TxtText[i] = "Inget innehåll inget inlägg.";
        i++;
        // 50
        TxtText[i] = "Du är inte behörig att skriva i denna tråd.";
        i++;
        // 51
        TxtText[i] = "Tråden går inte att hitta.";
        i++;
        // 52
        TxtText[i] = "reserve";
        i++;
        // 53
        TxtText[i] = "reserve";
        i++;
        // 54
        TxtText[i] = "reserve";
        i++;
        // 55
        TxtText[i] = "Tumme UPP för denna.";
        i++;
        // 56
        TxtText[i] = "Tumme ned för denna.";
        i++;
        // 57
        TxtText[i] = "Du ändrade dig.";
        i++;
        // 58
        TxtText[i] = "En räcker!";
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