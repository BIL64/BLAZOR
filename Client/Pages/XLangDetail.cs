public class XLangDetail // Implementerar det språk man valt via Local Storage.
{
    public string RenderPage { get; set; } = string.Empty;

    public string[] TxtTitle { get; private set; } = new string[34];

    public string[] TxtDateC { get; private set; } = new string[11];

    public string[] TxtText { get; private set; } = new string[23];

    public event Action? OnChange;

    private void Title_EN()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "reserve";
        i++;
        // 1
        TxtTitle[i] = "Perform a Date Check for this course";
        i++;
        // 2
        TxtTitle[i] = "Shortcut to the student page";
        i++;
        // 3
        TxtTitle[i] = "Add a document to this course";
        i++;
        // 4
        TxtTitle[i] = "-Click for edit-";
        i++;
        // 5
        TxtTitle[i] = "Click for edit. Type #E# for empty or #H# for hiding a field";
        i++;
        // 6
        TxtTitle[i] = "Click to change the order";
        i++;
        // 7
        TxtTitle[i] = "Click to edit the date";
        i++;
        // 8
        TxtTitle[i] = "Add a document to this module";
        i++;
        // 9
        TxtTitle[i] = "Show document";
        i++;
        // 10
        TxtTitle[i] = "Hide document";
        i++;
        // 11
        TxtTitle[i] = "reserve";
        i++;
        // 12
        TxtTitle[i] = "reserve";
        i++;
        // 13
        TxtTitle[i] = "reserve";
        i++;
        // 14
        TxtTitle[i] = "Type #E# for empty or #H# for hiding a field";
        i++;
        // 15
        TxtTitle[i] = "Copy another module into this module";
        i++;
        // 16
        TxtTitle[i] = "Simple text message";
        i++;
        // 17
        TxtTitle[i] = "Only activities";
        i++;
        // 18
        TxtTitle[i] = "Simple text as a heading for a module";
        i++;
        // 19
        TxtTitle[i] = "Extend with identity number";
        i++;
        // 20
        TxtTitle[i] = "Disable the module and exclude identity nr";
        i++;
        // 21
        TxtTitle[i] = "#r# = bold red, #m# = bold magenta, #g# = bold green, #b# = bold blue, #B# = black normal, #BB# = bold black, #i# = italic";
        i++;
        // 22
        TxtTitle[i] = "reserve";
        i++;
        // 23
        TxtTitle[i] = "reserve";
        i++;
        // 24
        TxtTitle[i] = "The name: ";
        i++;
        // 25
        TxtTitle[i] = "Add a document to this activity";
        i++;
        // 26
        TxtTitle[i] = "Disable this activity";
        i++;
        // 27
        TxtTitle[i] = "Disable this module";
        i++;
        // 28
        TxtTitle[i] = "Activate this activity";
        i++;
        // 29
        TxtTitle[i] = "Activate this module";
        i++;
        // 30
        TxtTitle[i] = "Click for more information...";
        i++;
        // 31
        TxtTitle[i] = "reserve";
        i++;
        // 32
        TxtTitle[i] = "reserve";
        i++;
        // 33
        TxtTitle[i] = "reserve";
    }

    private void Title_SV()
    {
        int i = 0;

        // 0
        TxtTitle[i] = "reserve";
        i++;
        // 1
        TxtTitle[i] = "Utför en datumkontroll för denna kurs";
        i++;
        // 2
        TxtTitle[i] = "Genväg till studentsidan";
        i++;
        // 3
        TxtTitle[i] = "Lägg till ett dokument till den här kursen";
        i++;
        // 4
        TxtTitle[i] = "-Klicka för redigering-";
        i++;
        // 5
        TxtTitle[i] = "Klicka för redigering. Skriv #E# för tomt eller #H# för att dölja ett fält";
        i++;
        // 6
        TxtTitle[i] = "Klicka för att ändra ordningen";
        i++;
        // 7
        TxtTitle[i] = "Klicka för att redigera datumet";
        i++;
        // 8
        TxtTitle[i] = "Lägg till ett dokument i den här modulen";
        i++;
        // 9
        TxtTitle[i] = "Visa dokument";
        i++;
        // 10
        TxtTitle[i] = "Dölj dokument";
        i++;
        // 11
        TxtTitle[i] = "reserve";
        i++;
        // 12
        TxtTitle[i] = "reserve";
        i++;
        // 13
        TxtTitle[i] = "reserve";
        i++;
        // 14
        TxtTitle[i] = "Skriv #E# för tomt eller #H# för att dölja ett fält";
        i++;
        // 15
        TxtTitle[i] = "Kopiera en annan modul till den här modulen";
        i++;
        // 16
        TxtTitle[i] = "Enkelt textmeddelande";
        i++;
        // 17
        TxtTitle[i] = "Endast aktiviteter";
        i++;
        // 18
        TxtTitle[i] = "Enkel text som rubrik för en modul";
        i++;
        // 19
        TxtTitle[i] = "Förläng med identitetsnummer";
        i++;
        // 20
        TxtTitle[i] = "Inaktivera modulen och exkludera identitetsnr";
        i++;
        // 21
        TxtTitle[i] = "#r# = fet röd, #m# = fet magenta, #g# = fet grön, #b# = fet blå, #B# = svart normal, #BB# = fet svart, #i# = kursiv";
        i++;
        // 22
        TxtTitle[i] = "reserve";
        i++;
        // 23
        TxtTitle[i] = "reserve";
        i++;
        // 24
        TxtTitle[i] = "Namnet: ";
        i++;
        // 25
        TxtTitle[i] = "Lägg till ett dokument till den här aktiviteten";
        i++;
        // 26
        TxtTitle[i] = "Inaktivera denna aktivitet";
        i++;
        // 27
        TxtTitle[i] = "Inaktivera denna modul";
        i++;
        // 28
        TxtTitle[i] = "Aktivera denna aktivitet";
        i++;
        // 29
        TxtTitle[i] = "Aktivera denna modul";
        i++;
        // 30
        TxtTitle[i] = "Klicka för mer information...";
        i++;
        // 31
        TxtTitle[i] = "reserve";
        i++;
        // 32
        TxtTitle[i] = "reserve";
        i++;
        // 33
        TxtTitle[i] = "reserve";
    }

    private void Title_DE()
    {
        // Deutsch
    }

    private void Title_FR()
    {
        // Français
    }

    private void DateC_EN()
    {
        int i = 0;

        // 0
        TxtDateC[i] = "reserve";
        i++;
        // 1
        TxtDateC[i] = "Perform calculation...";
        i++;
        // 2
        TxtDateC[i] = "Course date mismatch (start date is greater than end date).";
        i++;
        // 3
        TxtDateC[i] = "Cannot calculate.";
        i++;
        // 4
        TxtDateC[i] = "Module date mismatch (date is outside the course date).";
        i++;
        // 5
        TxtDateC[i] = "Module date mismatch (start date is greater than end date).";
        i++;
        // 6
        TxtDateC[i] = "Cannot calculate (overloading).";
        i++;
        // 7
        TxtDateC[i] = "Activity date mismatch (date is outside the module date).";
        i++;
        // 8
        TxtDateC[i] = "Activity date mismatch (start date is greater than end date).";
        i++;
        // 9
        TxtDateC[i] = "Date mismatch (entangled dates)";
        i++;
        // 10
        TxtDateC[i] = "No date errors could be found.";
    }

    private void DateC_SV()
    {
        int i = 0;

        // 0
        TxtDateC[i] = "reserve";
        i++;
        // 1
        TxtDateC[i] = "Utför beräkning...";
        i++;
        // 2
        TxtDateC[i] = "Kursdatum är felaktigt (startdatum är större än slutdatum).";
        i++;
        // 3
        TxtDateC[i] = "Kan inte beräkna.";
        i++;
        // 4
        TxtDateC[i] = "Moduldatum är felaktigt (datum är utanför kursdatum).";
        i++;
        // 5
        TxtDateC[i] = "Moduldatum är felaktigt (startdatum är större än slutdatum).";
        i++;
        // 6
        TxtDateC[i] = "Kan ej beräkna (överbelastning).";
        i++;
        // 7
        TxtDateC[i] = "Aktivitetsdatum är felaktigt (datum är utanför moduldatum).";
        i++;
        // 8
        TxtDateC[i] = "Aktivitetsdatum är felaktigt (startdatum är större än slutdatum).";
        i++;
        // 9
        TxtDateC[i] = "Datumfel (intrasslade datum)";
        i++;
        // 10
        TxtDateC[i] = "Inga datumfel kunde hittas.";
    }

    private void DateC_DE()
    {
        // Deutsch
    }

    private void DateC_FR()
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
        TxtText[i] = "Administration of this course";
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
        TxtText[i] = "Module";
        i++;
        // 9
        TxtText[i] = "Text message (the";
        i++;
        // 10
        TxtText[i] = "description";
        i++;
        // 11
        TxtText[i] = "of the aktivity)";
        i++;
        // 12
        TxtText[i] = "DISABLE";
        i++;
        // 13
        TxtText[i] = "Info about #T#";
        i++;
        // 14
        TxtText[i] = "The same thing can be accomplished by adding the text string #T# " +
                     "somewhere in the name of any activity and then disabling the activity " +
                     "(if you don't want both to appear). It is the same as here - that it is " +
                     "the description of the activity that constitutes the text message. The " +
                     "message is displayed after the current module.";
        i++;
        // 15
        TxtText[i] = "The current module.";
        i++;
        // 16
        TxtText[i] = "There is no current module.";
        i++;
        // 17
        TxtText[i] = "No module matched the search term...";
        i++;
        // 18
        TxtText[i] = "No course could be find...";
        i++;
        // 19
        TxtText[i] = "No modules could be find...";
        i++;
        // 20
        TxtText[i] = "There is a module whose order number is greater than the actual number of modules.";
        i++;
        // 21
        TxtText[i] = "There are several modules whose order number is greater than the actual number of modules.";
        i++;
        // 22
        TxtText[i] = "There is one or several modules whose name is equal. To avoid problems with handling data, all modules should have different names.";
    }

    private void Text_SV()
    {
        int i = 0;

        // 0
        TxtText[i] = "reserve";
        i++;
        // 1
        TxtText[i] = "Administration av denna kurs";
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
        TxtText[i] = "Modul";
        i++;
        // 9
        TxtText[i] = "Textmeddelandet (är";
        i++;
        // 10
        TxtText[i] = "beskrivningen";
        i++;
        // 11
        TxtText[i] = "av denna aktivitet)";
        i++;
        // 12
        TxtText[i] = "AVAKTIVERAD";
        i++;
        // 13
        TxtText[i] = "Info om #T#";
        i++;
        // 14
        TxtText[i] = "Samma sak kan åstadkommas genom att lägga till textsträngen #T# " +
                     "någonstans i namnet på någon aktivitet och sedan inaktivera aktiviteten " +
                     "(om du inte vill att båda ska visas). Det är samma sak som här – att det är " +
                     "beskrivningen av aktiviteten som utgör textmeddelandet. " +
                     "Meddelandet visas efter den aktuella modulen.";
        i++;
        // 15
        TxtText[i] = "Den aktuella modulen.";
        i++;
        // 16
        TxtText[i] = "Det finns ingen aktuell modul.";
        i++;
        // 17
        TxtText[i] = "Ingen modul motsvarar söktermen...";
        i++;
        // 18
        TxtText[i] = "Ingen kurs kan hittas...";
        i++;
        // 19
        TxtText[i] = "Ingen modul kan hittas...";
        i++;
        // 20
        TxtText[i] = "Det finns en modul vars ordernummer är större än det faktiska antalet moduler.";
        i++;
        // 21
        TxtText[i] = "Det finns flera moduler vars ordernummer är större än det faktiska antalet moduler.";
        i++;
        // 22
        TxtText[i] = "Det finns en eller flera moduler med identiska namn. För att undvika datahanteringsproblem så bör alla moduler ha olika namn.";
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
        Title_EN();
        Text_EN();
        DateC_EN();
        NotifyStateChanged();
    }

    public void SetLanguage_SV()
    {
        RenderPage = "STILL_HERE";
        Title_SV();
        Text_SV();
        DateC_SV();
        NotifyStateChanged();
    }

    public void SetLanguage_DE()
    {
        RenderPage = "STILL_HERE";
        Title_DE();
        Text_DE();
        DateC_DE();
        NotifyStateChanged();
    }

    public void SetLanguage_FR()
    {
        RenderPage = "STILL_HERE";
        Title_FR();
        Text_FR();
        DateC_FR();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}