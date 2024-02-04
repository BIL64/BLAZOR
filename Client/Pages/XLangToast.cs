public class XLangToast // Implementerar det språk man valt via Local Storage.
{
    public string[] TxtButton { get; private set; } = new string[16];

    public string[] TxtTitle { get; private set; } = new string[28];

    public string[] TxtHead { get; private set; } = new string[38];

    public string[] TxtText { get; private set; } = new string[62];

    public string[] TxtDone { get; private set; } = new string[47];

    public string[] TxtError { get; private set; } = new string[30];

    public event Action? OnChange;

    private void Button_EN()
    {
        int i = 0;

        // 0
        TxtButton[i] = "NO";
        i++;
        // 1
        TxtButton[i] = "DELETE";
        i++;
        // 2
        TxtButton[i] = "DELETE NOW";
        i++;
        // 3
        TxtButton[i] = "Delete file";
        i++;
        // 4
        TxtButton[i] = "Delete avatar";
        i++;
        // 5
        TxtButton[i] = "YES";
        i++;
        // 6
        TxtButton[i] = "Save";
        i++;
        // 7
        TxtButton[i] = "Save settings";
        i++;
        // 8
        TxtButton[i] = "Save avatar";
        i++;
        // 9
        TxtButton[i] = "File / Message";
        i++;
        // 10
        TxtButton[i] = "To teacher";
        i++;
        // 11
        TxtButton[i] = "To student";
        i++;
        // 12
        TxtButton[i] = "Copy";
        i++;
        // 13
        TxtButton[i] = "This Into New";
        i++;
        // 14
        TxtButton[i] = "CENSOR";
        i++;
        // 15
        TxtButton[i] = "Send";
    }

    private void Button_SV()
    {
        int i = 0;

        // 0
        TxtButton[i] = "NEJ";
        i++;
        // 1
        TxtButton[i] = "RADERA";
        i++;
        // 2
        TxtButton[i] = "RADERA NU";
        i++;
        // 3
        TxtButton[i] = "Radera fil";
        i++;
        // 4
        TxtButton[i] = "Radera avatar";
        i++;
        // 5
        TxtButton[i] = "JA";
        i++;
        // 6
        TxtButton[i] = "Spara";
        i++;
        // 7
        TxtButton[i] = "Spara inställningar";
        i++;
        // 8
        TxtButton[i] = "Spara avatar";
        i++;
        // 9
        TxtButton[i] = "Fil / Meddelande";
        i++;
        // 10
        TxtButton[i] = "Till lärare";
        i++;
        // 11
        TxtButton[i] = "Till elev";
        i++;
        // 12
        TxtButton[i] = "Kopiera";
        i++;
        // 13
        TxtButton[i] = "Till en ny";
        i++;
        // 14
        TxtButton[i] = "CENSURERA";
        i++;
        // 15
        TxtButton[i] = "Posta";
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
        TxtTitle[i] = "Save settings";
        i++;
        // 2
        TxtTitle[i] = "Copy a module to this module";
        i++;
        // 3
        TxtTitle[i] = "Make a new copy with this module except for the documents";
        i++;
        // 4
        TxtTitle[i] = "Remove all non-mandatory documents and messages from the system";
        i++;
        // 5
        TxtTitle[i] = "Remove all visitors from the system";
        i++;
        // 6
        TxtTitle[i] = "Remove this message from the system";
        i++;
        // 7
        TxtTitle[i] = "Users email";
        i++;
        // 8
        TxtTitle[i] = "Remove this user from the system";
        i++;
        // 9
        TxtTitle[i] = "Make this student a teacher...";
        i++;
        // 10
        TxtTitle[i] = "Make this teacher a student...";
        i++;
        // 11
        TxtTitle[i] = "Remove this module and all its activities from the system";
        i++;
        // 12
        TxtTitle[i] = "reserve";
        i++;
        // 13
        TxtTitle[i] = "reserve";
        i++;
        // 14
        TxtTitle[i] = "Make this visitor a teacher...";
        i++;
        // 15
        TxtTitle[i] = "Toggle between file and message";
        i++;
        // 16
        TxtTitle[i] = "Remove this file from the system";
        i++;
        // 17
        TxtTitle[i] = "Maximum number of rows for a page";
        i++;
        // 18
        TxtTitle[i] = "To reduce the number of visible buttons (1=none)";
        i++;
        // 19
        TxtTitle[i] = "Today's date";
        i++;
        // 20
        TxtTitle[i] = "reserve";
        i++;
        // 21
        TxtTitle[i] = "reserve";
        i++;
        // 22
        TxtTitle[i] = "reserve";
        i++;
        // 23
        TxtTitle[i] = "Add a new thread or save this edited form";
        i++;
        // 24
        TxtTitle[i] = "Remove thread";
        i++;
        // 25
        TxtTitle[i] = "Save this edited form";
        i++;
        // 26
        TxtTitle[i] = "Remove this post from the system";
        i++;
        // 27
        TxtTitle[i] = "Censor this post";
    }

    private void Title_SV()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "reserve";
        i++;
        // 1
        TxtTitle[i] = "Spara inställningarna";
        i++;
        // 2
        TxtTitle[i] = "Kopiera en modul till denna modul";
        i++;
        // 3
        TxtTitle[i] = "Gör en ny kopia med denna modul förutom dokumenten";
        i++;
        // 4
        TxtTitle[i] = "Ta bort alla icke-obligatoriska dokument och meddelanden från systemet";
        i++;
        // 5
        TxtTitle[i] = "Ta bort alla besökare från systemet";
        i++;
        // 6
        TxtTitle[i] = "Ta bort detta meddelande från systemet";
        i++;
        // 7
        TxtTitle[i] = "Användarens e-postadress";
        i++;
        // 8
        TxtTitle[i] = "Ta bort denna användare från systemet";
        i++;
        // 9
        TxtTitle[i] = "Gör den här eleven till en lärare...";
        i++;
        // 10
        TxtTitle[i] = "Gör den här läraren till en elev...";
        i++;
        // 11
        TxtTitle[i] = "Ta bort den här modulen och alla dess aktiviteter från systemet";
        i++;
        // 12
        TxtTitle[i] = "reserve";
        i++;
        // 13
        TxtTitle[i] = "reserve";
        i++;
        // 14
        TxtTitle[i] = "Gör den här besökaren till en lärare...";
        i++;
        // 15
        TxtTitle[i] = "Växla mellan fil och meddelande";
        i++;
        // 16
        TxtTitle[i] = "Ta bort den här filen från systemet";
        i++;
        // 17
        TxtTitle[i] = "Maximalt antal rader för en sida";
        i++;
        // 18
        TxtTitle[i] = "För att minska antalet synliga knappar (1=normal)";
        i++;
        // 19
        TxtTitle[i] = "Dagens datum";
        i++;
        // 20
        TxtTitle[i] = "reserve";
        i++;
        // 21
        TxtTitle[i] = "reserve";
        i++;
        // 22
        TxtTitle[i] = "reserve";
        i++;
        // 23
        TxtTitle[i] = "Lägg till en ny tråd eller spara detta redigerade formulär";
        i++;
        // 24
        TxtTitle[i] = "Ta bort tråd";
        i++;
        // 25
        TxtTitle[i] = "Spara detta redigerade formulär";
        i++;
        // 26
        TxtTitle[i] = "Ta bort det här inlägget från systemet";
        i++;
        // 27
        TxtTitle[i] = "Censurera detta inlägg";
    }

    private void Title_DE()
    {
        // Deutsch
    }

    private void Title_FR()
    {
        // Français
    }

    private void Head_EN()
    {
        int i = 0;

        // 0
        TxtHead[i] = "reserve";
        i++;
        // 1
        TxtHead[i] = "Copy module...";
        i++;
        // 2
        TxtHead[i] = "Remove this module...";
        i++;
        // 3
        TxtHead[i] = "Eliminate all your docs and mess...";
        i++;
        // 4
        TxtHead[i] = "Remove all visitors...";
        i++;
        // 5
        TxtHead[i] = "Remove message...";
        i++;
        // 6
        TxtHead[i] = "reserve";
        i++;
        // 7
        TxtHead[i] = "Remove this user...";
        i++;
        // 8
        TxtHead[i] = "Add or delete avatar...";
        i++;
        // 9
        TxtHead[i] = "Your document file...";
        i++;
        // 10
        TxtHead[i] = "Edit dates for this activity...";
        i++;
        // 11
        TxtHead[i] = "reserve";
        i++;
        // 12
        TxtHead[i] = "reserve";
        i++;
        // 13
        TxtHead[i] = "reserve";
        i++;
        // 14
        TxtHead[i] = "Edit dates for this module...";
        i++;
        // 15
        TxtHead[i] = "Set new module position...";
        i++;
        // 16
        TxtHead[i] = "Pagination settings...";
        i++;
        // 17
        TxtHead[i] = "Add MEMBER document file...";
        i++;
        // 18
        TxtHead[i] = "Add COURSE document file...";
        i++;
        // 19
        TxtHead[i] = "Add MODULE document file...";
        i++;
        // 20
        TxtHead[i] = "Add ACTIVITY document file...";
        i++;
        // 21
        TxtHead[i] = "reserve";
        i++;
        // 22
        TxtHead[i] = "reserve";
        i++;
        // 23
        TxtHead[i] = "reserve";
        i++;
        // 24
        TxtHead[i] = "Add MEMBER file or message...";
        i++;
        // 25
        TxtHead[i] = "Add COURSE file or message...";
        i++;
        // 26
        TxtHead[i] = "Add MODULE file or message...";
        i++;
        // 27
        TxtHead[i] = "Add ACTIVITY file or message...";
        i++;
        // 28
        TxtHead[i] = "Edit MEMBER document file...";
        i++;
        // 29
        TxtHead[i] = "Edit COURSE document file...";
        i++;
        // 30
        TxtHead[i] = "Edit MODULE document file...";
        i++;
        // 31
        TxtHead[i] = "Edit ACTIVITY document file...";
        i++;
        // 32
        TxtHead[i] = "reserve";
        i++;
        // 33
        TxtHead[i] = "reserve";
        i++;
        // 34
        TxtHead[i] = "reserve";
        i++;
        // 35
        TxtHead[i] = "Add or edit a thread...";
        i++;
        // 36
        TxtHead[i] = "Delete a thread...";
        i++;
        // 37
        TxtHead[i] = "Edit this post...";
    }

    private void Head_SV()
    {
        int i = 0;

        // 0
        TxtHead[i] = "reserve";
        i++;
        // 1
        TxtHead[i] = "Kopiera modul...";
        i++;
        // 2
        TxtHead[i] = "Ta bort den här modulen...";
        i++;
        // 3
        TxtHead[i] = "Eliminera alla dina docs & mess...";
        i++;
        // 4
        TxtHead[i] = "Ta bort alla besökare...";
        i++;
        // 5
        TxtHead[i] = "Ta bort meddelandet...";
        i++;
        // 6
        TxtHead[i] = "reserve";
        i++;
        // 7
        TxtHead[i] = "Ta bort den här användaren...";
        i++;
        // 8
        TxtHead[i] = "Lägg till eller radera avatar...";
        i++;
        // 9
        TxtHead[i] = "Din dokumentfil...";
        i++;
        // 10
        TxtHead[i] = "Redigera datum för denna aktivitet...";
        i++;
        // 11
        TxtHead[i] = "reserve";
        i++;
        // 12
        TxtHead[i] = "reserve";
        i++;
        // 13
        TxtHead[i] = "reserve";
        i++;
        // 14
        TxtHead[i] = "Redigera datum för denna modul...";
        i++;
        // 15
        TxtHead[i] = "Placera om denna modul...";
        i++;
        // 16
        TxtHead[i] = "Inställningar för personsökning...";
        i++;
        // 17
        TxtHead[i] = "Posta PERSON-dokumentfil...";
        i++;
        // 18
        TxtHead[i] = "Posta KURS-dokumentfil...";
        i++;
        // 19
        TxtHead[i] = "Posta MODUL-dokumentfil...";
        i++;
        // 20
        TxtHead[i] = "Posta AKTIVITET-dokumentfil...";
        i++;
        // 21
        TxtHead[i] = "reserve";
        i++;
        // 22
        TxtHead[i] = "reserve";
        i++;
        // 23
        TxtHead[i] = "reserve";
        i++;
        // 24
        TxtHead[i] = "Posta PERSON-fil eller meddelande...";
        i++;
        // 25
        TxtHead[i] = "Posta KURS-fil eller meddelande...";
        i++;
        // 26
        TxtHead[i] = "Posta MODUL-fil eller meddelande...";
        i++;
        // 27
        TxtHead[i] = "Posta AKTIVITETS-fil eller meddelande...";
        i++;
        // 28
        TxtHead[i] = "Redigera PERSON dokumentfil...";
        i++;
        // 29
        TxtHead[i] = "Redigera KURS dokumentfil...";
        i++;
        // 30
        TxtHead[i] = "Redigera MODUL dokumentfil...";
        i++;
        // 31
        TxtHead[i] = "Redigera AKTIVITET dokumentfil...";
        i++;
        // 32
        TxtHead[i] = "reserve";
        i++;
        // 33
        TxtHead[i] = "reserve";
        i++;
        // 34
        TxtHead[i] = "reserve";
        i++;
        // 35
        TxtHead[i] = "Lägg till eller redigera en tråd...";
        i++;
        // 36
        TxtHead[i] = "Ta bort en tråd...";
        i++;
        // 37
        TxtHead[i] = "Redigera detta inlägg...";
    }

    private void Head_DE()
    {
        // Deutsch
    }

    private void Head_FR()
    {
        // Français
    }

    private void Text_EN()
    {
        int i = 0;

        // 0
        TxtText[i] = "Documents will be moved (not copied) and all documents belonging to this module deleted.";
        i++;
        // 1
        TxtText[i] = "This into new - button will create a new module that is a copy of this module and all its " +
                     "activities but do not care for any documents.";
        i++;
        // 2
        TxtText[i] = "Copy the module but do not move any document";
        i++;
        // 3
        TxtText[i] = "Move all documents";
        i++;
        // 4
        TxtText[i] = "Move module documents only";
        i++;
        // 5
        TxtText[i] = "Move activity documents only";
        i++;
        // 6
        TxtText[i] = "Search the module in this course";
        i++;
        // 7
        TxtText[i] = "Type the module name";
        i++;
        // 8
        TxtText[i] = "Enter today's date (yyyy-mm-dd)";
        i++;
        // 9
        TxtText[i] = "Enter your email address";
        i++;
        // 10
        TxtText[i] = "Description / message";
        i++;
        // 11
        TxtText[i] = "Author / sender";
        i++;
        // 12
        TxtText[i] = "reserve";
        i++;
        // 13
        TxtText[i] = "Avatar file types are .png or .jpeg.";
        i++;
        // 14
        TxtText[i] = "Max file size:";
        i++;
        // 15
        TxtText[i] = "Optimal image size (WxH) is 225 x 225 pixels.";
        i++;
        // 16
        TxtText[i] = "Description";
        i++;
        // 17
        TxtText[i] = "Author (sender)";
        i++;
        // 18
        TxtText[i] = "Set start date";
        i++;
        // 19
        TxtText[i] = "Set end date";
        i++;
        // 20
        TxtText[i] = "If you want to add more modules somewhere in the course or for some other reason " +
                     "wish to change the position of a module, then you can enter a suitable value here. " +
                     "For example, 1 becomes the first module. 0 means that the module will retain its " +
                     "original position.";
        i++;
        // 21
        TxtText[i] = "Enter position";
        i++;
        // 22
        TxtText[i] = "reserve";
        i++;
        // 23
        TxtText[i] = "reserve";
        i++;
        // 24
        TxtText[i] = "reserve";
        i++;
        // 25
        TxtText[i] = "Set rows";
        i++;
        // 26
        TxtText[i] = "Set reducing nr.";
        i++;
        // 27
        TxtText[i] = "* M E S S A G E *";
        i++;
        // 28
        TxtText[i] = "* F I L E *";
        i++;
        // 29
        TxtText[i] = "Working...";
        i++;
        // 30
        TxtText[i] = "reserve";
        i++;
        // 31
        TxtText[i] = "reserve";
        i++;
        // 32
        TxtText[i] = "reserve";
        i++;
        // 33
        TxtText[i] = "Mandatory thread for a selected course";
        i++;
        // 34
        TxtText[i] = "Mandatory thread for all courses";
        i++;
        // 35
        TxtText[i] = "Open thread for all users";
        i++;
        // 36
        TxtText[i] = "Private thread";
        i++;
        // 37
        TxtText[i] = "Select course";
        i++;
        // 38
        TxtText[i] = "Select a discussion partner";
        i++;
        // 39
        TxtText[i] = "Type a name for this thread";
        i++;
        // 40
        TxtText[i] = "Private threads are only available to those selected (two participants).";
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
        TxtText[i] = "The thread “";
        i++;
        // 45
        TxtText[i] = "” will be edited. Do not";
        i++;
        // 46
        TxtText[i] = "open";
        i++;
        // 47
        TxtText[i] = "any thread before choosing to create a new one!";
        i++;
        // 48
        TxtText[i] = "Remove a specific saved thread";
        i++;
        // 49
        TxtText[i] = "Remove all saved thread (reset)";
        i++;
        // 50
        TxtText[i] = "Remove the thread from the database";
        i++;
        // 51
        TxtText[i] = "reserve";
        i++;
        // 52
        TxtText[i] = "reserve";
        i++;
        // 53
        TxtText[i] = "reserve";
        i++;
        // 54
        TxtText[i] = "Type the thread name";
        i++;
        // 55
        TxtText[i] = "This will delete all your saved threads!";
        i++;
        // 56
        TxtText[i] = "This irrevocably eliminates the thread and all its posts!";
        i++;
        // 57
        TxtText[i] = "Header...";
        i++;
        // 58
        TxtText[i] = "Just edit the text";
        i++;
        // 59
        TxtText[i] = "Permit to censor post";
        i++;
        // 60
        TxtText[i] = "Permit to uncensor post";
        i++;
        // 61
        TxtText[i] = "Permit to delete the post from the database";
    }

    private void Text_SV()
    {
        int i = 0;

        // 0
        TxtText[i] = "Dokument kommer att flyttas (inte kopieras) och alla dokument som tillhör denna modul raderas.";
        i++;
        // 1
        TxtText[i] = "Till en ny - knappen skapar en ny modul som är en kopia av denna modul och alla dess " +
                     "aktiviteter men bryr sig inte om att flytta några dokument.";
        i++;
        // 2
        TxtText[i] = "Kopiera modulen men flytta inga dokument";
        i++;
        // 3
        TxtText[i] = "Flytta alla dokument";
        i++;
        // 4
        TxtText[i] = "Flytta endast moduldokumenten";
        i++;
        // 5
        TxtText[i] = "Flytta endast aktivitetsdokumenten";
        i++;
        // 6
        TxtText[i] = "Sök efter modulen i denna kurs";
        i++;
        // 7
        TxtText[i] = "Ange modulens namn";
        i++;
        // 8
        TxtText[i] = "Ange dagens datum (åååå-mm-dd)";
        i++;
        // 9
        TxtText[i] = "Ange din e-postadress";
        i++;
        // 10
        TxtText[i] = "Beskrivning / meddelande";
        i++;
        // 11
        TxtText[i] = "Skribent / avsändare";
        i++;
        // 12
        TxtText[i] = "reserve";
        i++;
        // 13
        TxtText[i] = "Avatar-filtyper är .png eller .jpeg.";
        i++;
        // 14
        TxtText[i] = "Max filstorlek:";
        i++;
        // 15
        TxtText[i] = "Optimal bildstorlek (BxH) är 225 x 225 pixlar.";
        i++;
        // 16
        TxtText[i] = "Beskrivning";
        i++;
        // 17
        TxtText[i] = "Skribent (avsändare)";
        i++;
        // 18
        TxtText[i] = "Ange startdatum";
        i++;
        // 19
        TxtText[i] = "Ange slutdatum";
        i++;
        // 20
        TxtText[i] = "Om du vill lägga till fler moduler någonstans i kursen eller om du av någon annan " +
                     "anledning önskar ändra positionen för en modul så kan du ange ett lämpligt värde här. " +
                     "Till exempel: 1 blir den första modulen och 0 betyder att modulen kommer att behålla " +
                     "sin ursprunglig position.";
        i++;
        // 21
        TxtText[i] = "Ange position";
        i++;
        // 22
        TxtText[i] = "reserve";
        i++;
        // 23
        TxtText[i] = "reserve";
        i++;
        // 24
        TxtText[i] = "reserve";
        i++;
        // 25
        TxtText[i] = "Ange rader";
        i++;
        // 26
        TxtText[i] = "Ange reduceringsnr.";
        i++;
        // 27
        TxtText[i] = "* M E D D E L A N D E *";
        i++;
        // 28
        TxtText[i] = "* F I L *";
        i++;
        // 29
        TxtText[i] = "Arbetar...";
        i++;
        // 30
        TxtText[i] = "reserve";
        i++;
        // 31
        TxtText[i] = "reserve";
        i++;
        // 32
        TxtText[i] = "reserve";
        i++;
        // 33
        TxtText[i] = "Obligatorisk tråd för vald kurs";
        i++;
        // 34
        TxtText[i] = "Obligatorisk tråd för alla kurser";
        i++;
        // 35
        TxtText[i] = "Öppen tråd för alla användare";
        i++;
        // 36
        TxtText[i] = "Privat tråd";
        i++;
        // 37
        TxtText[i] = "Välj kurs";
        i++;
        // 38
        TxtText[i] = "Välj en diskussionspartner";
        i++;
        // 39
        TxtText[i] = "Ange ett namn för denna tråd";
        i++;
        // 40
        TxtText[i] = "Privata trådar är endast tillgängliga för de utvalda (två deltagare).";
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
        TxtText[i] = "Tråden ”";
        i++;
        // 45
        TxtText[i] = "” kommer att bli redigerad.";
        i++;
        // 46
        TxtText[i] = "Öppna";
        i++;
        // 47
        TxtText[i] = "inte någon tråd innan du väljer att skapa en ny!";
        i++;
        // 48
        TxtText[i] = "Ta bort en specifik sparad tråd";
        i++;
        // 49
        TxtText[i] = "Ta bort alla sparade trådar (återställ)";
        i++;
        // 50
        TxtText[i] = "Ta bort tråden från databasen";
        i++;
        // 51
        TxtText[i] = "reserve";
        i++;
        // 52
        TxtText[i] = "reserve";
        i++;
        // 53
        TxtText[i] = "reserve";
        i++;
        // 54
        TxtText[i] = "Ange trådens namn";
        i++;
        // 55
        TxtText[i] = "Detta kommer att radera alla dina sparade trådar!";
        i++;
        // 56
        TxtText[i] = "Detta eliminerar oåterkalleligt tråden och alla dess inlägg!";
        i++;
        // 57
        TxtText[i] = "Rubrik...";
        i++;
        // 58
        TxtText[i] = "Redigera enbart texten";
        i++;
        // 59
        TxtText[i] = "Tillåt att censurera inlägget";
        i++;
        // 60
        TxtText[i] = "Tillåt att avcensurera inlägget";
        i++;
        // 61
        TxtText[i] = "Tillåt att radera inlägget från databasen";
    }

    private void Text_DE()
    {
        // Deutsch
    }

    private void Text_FR()
    {
        // Français
    }

    private void Done_EN()
    {
        int i = 0;

        // 0
        TxtDone[i] = "reserve";
        i++;
        // 1
        TxtDone[i] = "A new module has been created.";
        i++;
        // 2
        TxtDone[i] = "The module has been copied.";
        i++;
        // 3
        TxtDone[i] = "This module and all its documents and activities were deleted.";
        i++;
        // 4
        TxtDone[i] = "No documents or messages could be found.";
        i++;
        // 5
        TxtDone[i] = "All your documents and messages were deleted.";
        i++;
        // 6
        TxtDone[i] = "All unregistered visitors were deleted.";
        i++;
        // 7
        TxtDone[i] = "This message was deleted.";
        i++;
        // 8
        TxtDone[i] = "All non-mandatory documents and messages were deleted.";
        i++;
        // 9
        TxtDone[i] = "This student was deleted.";
        i++;
        // 10
        TxtDone[i] = "This student was redirected to a teacher.";
        i++;
        // 11
        TxtDone[i] = "reserve";
        i++;
        // 12
        TxtDone[i] = "reserve";
        i++;
        // 13
        TxtDone[i] = "reserve";
        i++;
        // 14
        TxtDone[i] = "This teacher was deleted.";
        i++;
        // 15
        TxtDone[i] = "This teacher was redirected to a student.";
        i++;
        // 16
        TxtDone[i] = "This unregistered visitor was deleted. Press “Search” for refreshing.";
        i++;
        // 17
        TxtDone[i] = "This unregistered visitor was redirected to a teacher. Press “Search” for refreshing.";
        i++;
        // 18
        TxtDone[i] = "Selected file Ok.";
        i++;
        // 19
        TxtDone[i] = "Your document file was added.";
        i++;
        // 20
        TxtDone[i] = "Your message was posted.";
        i++;
        // 21
        TxtDone[i] = "reserve";
        i++;
        // 22
        TxtDone[i] = "reserve";
        i++;
        // 23
        TxtDone[i] = "reserve";
        i++;
        // 24
        TxtDone[i] = "Your avatar was added.";
        i++;
        // 25
        TxtDone[i] = "Your avatar was deleted.";
        i++;
        // 26
        TxtDone[i] = "Your document file was edited.";
        i++;
        // 27
        TxtDone[i] = "Your document file was deleted.";
        i++;
        // 28
        TxtDone[i] = "This document file was deleted.";
        i++;
        // 29
        TxtDone[i] = "The dates were saved.";
        i++;
        // 30
        TxtDone[i] = "A new position.";
        i++;
        // 31
        TxtDone[i] = "reserve";
        i++;
        // 32
        TxtDone[i] = "reserve";
        i++;
        // 33
        TxtDone[i] = "reserve";
        i++;
        // 34
        TxtDone[i] = "This thread has been edited.";
        i++;
        // 35
        TxtDone[i] = "A new thread has been created.";
        i++;
        // 36
        TxtDone[i] = "This saved thread was deleted.";
        i++;
        // 37
        TxtDone[i] = "Saved threads have been reset.";
        i++;
        // 38
        TxtDone[i] = "This thread was deleted from the database.";
        i++;
        // 39
        TxtDone[i] = "This post is legit and/or not edited.";
        i++;
        // 40
        TxtDone[i] = "The post has been edited.";
        i++;
        // 41
        TxtDone[i] = "The post has not been edited.";
        i++;
        // 42
        TxtDone[i] = "reserve";
        i++;
        // 43
        TxtDone[i] = "reserve";
        i++;
        // 44
        TxtDone[i] = "reserve";
        i++;
        // 45
        TxtDone[i] = "This post has been censored.";
        i++;
        // 46
        TxtDone[i] = "This post was deleted from the database.";
    }

    private void Done_SV()
    {
        int i = 0;

        // 0
        TxtDone[i] = "reserve";
        i++;
        // 1
        TxtDone[i] = "En ny modul har skapats.";
        i++;
        // 2
        TxtDone[i] = "Modulen har kopierats.";
        i++;
        // 3
        TxtDone[i] = "Denna modul och alla dess dokument och aktiviteter raderades.";
        i++;
        // 4
        TxtDone[i] = "Inga dokument eller meddelanden kunde hittas.";
        i++;
        // 5
        TxtDone[i] = "Alla dina dokument och meddelanden raderades.";
        i++;
        // 6
        TxtDone[i] = "Alla oregistrerade besökare raderades.";
        i++;
        // 7
        TxtDone[i] = "Detta meddelande raderades.";
        i++;
        // 8
        TxtDone[i] = "Alla icke-obligatoriska dokument och meddelanden raderades.";
        i++;
        // 9
        TxtDone[i] = "Den här eleven togs bort.";
        i++;
        // 10
        TxtDone[i] = "Den här eleven omdirigerades till en lärare.";
        i++;
        // 11
        TxtDone[i] = "reserve";
        i++;
        // 12
        TxtDone[i] = "reserve";
        i++;
        // 13
        TxtDone[i] = "reserve";
        i++;
        // 14
        TxtDone[i] = "Den här läraren togs bort.";
        i++;
        // 15
        TxtDone[i] = "Den här läraren omdirigerades till en elev.";
        i++;
        // 16
        TxtDone[i] = "Denna oregistrerade besökare raderades. Tryck på ”Search” för att uppdatera.";
        i++;
        // 17
        TxtDone[i] = "Denna oregistrerade besökare omdirigerades till en lärare. Tryck på ”Search” för att uppdatera.";
        i++;
        // 18
        TxtDone[i] = "Vald fil Ok.";
        i++;
        // 19
        TxtDone[i] = "Din dokumentfil lades till.";
        i++;
        // 20
        TxtDone[i] = "Ditt meddelande postades.";
        i++;
        // 21
        TxtDone[i] = "reserve";
        i++;
        // 22
        TxtDone[i] = "reserve";
        i++;
        // 23
        TxtDone[i] = "reserve";
        i++;
        // 24
        TxtDone[i] = "Din avatar har lagts till.";
        i++;
        // 25
        TxtDone[i] = "Din avatar raderades.";
        i++;
        // 26
        TxtDone[i] = "Din dokumentfil har redigerats.";
        i++;
        // 27
        TxtDone[i] = "Din dokumentfil togs bort.";
        i++;
        // 28
        TxtDone[i] = "Denna dokumentfil togs bort.";
        i++;
        // 29
        TxtDone[i] = "Datumen sparades.";
        i++;
        // 30
        TxtDone[i] = "En ny position.";
        i++;
        // 31
        TxtDone[i] = "reserve";
        i++;
        // 32
        TxtDone[i] = "reserve";
        i++;
        // 33
        TxtDone[i] = "reserve";
        i++;
        // 34
        TxtDone[i] = "Den här tråden har redigerats.";
        i++;
        // 35
        TxtDone[i] = "En ny tråd har skapats.";
        i++;
        // 36
        TxtDone[i] = "Den här sparade tråden raderades.";
        i++;
        // 37
        TxtDone[i] = "Sparade trådar har nollställts";
        i++;
        // 38
        TxtDone[i] = "Den här tråden togs bort från databasen.";
        i++;
        // 39
        TxtDone[i] = "Detta inlägg är legitimt och/eller inte redigerat.";
        i++;
        // 40
        TxtDone[i] = "Inlägget har redigerats.";
        i++;
        // 41
        TxtDone[i] = "Inlägget har inte redigerats.";
        i++;
        // 42
        TxtDone[i] = "reserve";
        i++;
        // 43
        TxtDone[i] = "reserve";
        i++;
        // 44
        TxtDone[i] = "reserve";
        i++;
        // 45
        TxtDone[i] = "Det här inlägget har censurerats.";
        i++;
        // 46
        TxtDone[i] = "Detta inlägg raderades från databasen.";
    }

    private void Done_DE()
    {
        // Deutsch
    }

    private void Done_FR()
    {
        // Français
    }

    private void Error_EN()
    {
        int i = 0;

        // 0
        TxtError[i] = "reserve";
        i++;
        // 1
        TxtError[i] = "A module named ";
        i++;
        // 2
        TxtError[i] = " was not found in this course.";
        i++;
        // 3
        TxtError[i] = " was not found.";
        i++;
        // 4
        TxtError[i] = "Cannot copy with the same name.";
        i++;
        // 5
        TxtError[i] = "The date was incorrect.";
        i++;
        // 6
        TxtError[i] = "The email address was incorrect.";
        i++;
        // 7
        TxtError[i] = "All documents or messages belonging to a student must first be " +
                      "deleted before the student can be deleted.";
        i++;
        // 8
        TxtError[i] = "All documents or messages belonging to a teacher must first be " +
                      "deleted before the teacher can be deleted.";
        i++;
        // 9
        TxtError[i] = " was not selected(Error: 6): ";
        i++;
        // 10
        TxtError[i] = "Failed to set a unique filename index.";
        i++;
        // 11
        TxtError[i] = "No documents or messages could be found.";
        i++;
        // 12
        TxtError[i] = "reserve";
        i++;
        // 13
        TxtError[i] = "reserve";
        i++;
        // 14
        TxtError[i] = "The file was not approved or was never selected.";
        i++;
        // 15
        TxtError[i] = "Failed to set a unique avatar name.";
        i++;
        // 16
        TxtError[i] = "An error occurred while saving activity.";
        i++;
        // 17
        TxtError[i] = "An error occurred while saving module.";
        i++;
        // 18
        TxtError[i] = "A position cannot apply twice.";
        i++;
        // 19
        TxtError[i] = "The position exceeds the number of modules.";
        i++;
        // 20
        TxtError[i] = "An error occurred while saving to Local Storage.";
        i++;
        // 21
        TxtError[i] = "reserve";
        i++;
        // 22
        TxtError[i] = "reserve";
        i++;
        // 23
        TxtError[i] = "reserve";
        i++;
        // 24
        TxtError[i] = "No course was selected.";
        i++;
        // 25
        TxtError[i] = "This thread name already exists.";
        i++;
        // 26
        TxtError[i] = "Character length error (0 < name < 26). Change the length of the thread name.";
        i++;
        // 27
        TxtError[i] = "The thread cannot be found.";
        i++;
        // 28
        TxtError[i] = "The thread cannot be found. You can only delete your own threads.";
        i++;
        // 29
        TxtError[i] = "The post cannot be found.";
    }

    private void Error_SV()
    {
        int i = 0;

        // 0
        TxtError[i] = "reserve";
        i++;
        // 1
        TxtError[i] = "En modul som heter ";
        i++;
        // 2
        TxtError[i] = " hittades inte i denna kurs.";
        i++;
        // 3
        TxtError[i] = " hittades inte.";
        i++;
        // 4
        TxtError[i] = "Kan inte kopiera med samma namn.";
        i++;
        // 5
        TxtError[i] = "Datumet var felaktigt.";
        i++;
        // 6
        TxtError[i] = "E-postadressen var felaktig.";
        i++;
        // 7
        TxtError[i] = "Alla dokument eller meddelanden som hör till en elev måste först " +
                      "raderas innan studenten kan raderas.";
        i++;
        // 8
        TxtError[i] = "Alla dokument eller meddelanden som hör till en lärare måste först " +
                      "raderas innan läraren kan raderas.";
        i++;
        // 9
        TxtError[i] = " blev inte vald (Error: 6): ";
        i++;
        // 10
        TxtError[i] = "Det gick inte att sätta ett unikt filnamnsindex.";
        i++;
        // 11
        TxtError[i] = "Inga dokument eller meddelanden kunde hittas.";
        i++;
        // 12
        TxtError[i] = "reserve";
        i++;
        // 13
        TxtError[i] = "reserve";
        i++;
        // 14
        TxtError[i] = "Filen godkändes inte eller valdes aldrig.";
        i++;
        // 15
        TxtError[i] = "Det gick inte att sätta ett unikt avatarnamn.";
        i++;
        // 16
        TxtError[i] = "Ett fel uppstod när aktiviteten skulle sparas.";
        i++;
        // 17
        TxtError[i] = "Ett fel uppstod när modulen skulle sparas.";
        i++;
        // 18
        TxtError[i] = "Ett positionsnummer kan inte förekomma två gånger.";
        i++;
        // 19
        TxtError[i] = "Positionsangivelsen överskred antalet moduler.";
        i++;
        // 20
        TxtError[i] = "Ett fel uppstod vid skrivning i Local Storage.";
        i++;
        // 21
        TxtError[i] = "reserve";
        i++;
        // 22
        TxtError[i] = "reserve";
        i++;
        // 23
        TxtError[i] = "reserve";
        i++;
        // 24
        TxtError[i] = "Ingen kurs valdes.";
        i++;
        // 25
        TxtError[i] = "Detta trådnamn finns redan.";
        i++;
        // 26
        TxtError[i] = "Teckenlängdsfel (0 < namn < 26). Ändra längden på trådnamnet.";
        i++;
        // 27
        TxtError[i] = "Tråden kan inte hittas.";
        i++;
        // 28
        TxtError[i] = "Tråden kan inte hittas. Du kan bara ta bort dina egna trådar.";
        i++;
        // 29
        TxtError[i] = "Inlägget kan inte hittas.";
    }

    private void Error_DE()
    {
        // Deutsch
    }

    private void Error_FR()
    {
        // Français
    }

    public void SetLanguage_EN()
    {
        Button_EN();
        Title_EN();
        Head_EN();
        Text_EN();
        Done_EN();
        Error_EN();
        NotifyStateChanged();
    }

    public void SetLanguage_SV()
    {
        Button_SV();
        Title_SV();
        Head_SV();
        Text_SV();
        Done_SV();
        Error_SV();
        NotifyStateChanged();
    }

    public void SetLanguage_DE()
    {
        Button_DE();
        Title_DE();
        Head_DE();
        Text_DE();
        Done_DE();
        Error_DE();
        NotifyStateChanged();
    }

    public void SetLanguage_FR()
    {
        Button_FR();
        Title_FR();
        Head_FR();
        Text_FR();
        Done_FR();
        Error_FR();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}