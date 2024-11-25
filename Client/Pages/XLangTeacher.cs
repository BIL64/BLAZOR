namespace LexiconLMSBlazor.Client.Pages
{
    public class XLangTeacher // Implementerar det språk man valt via Local Storage.
    {
        public string RenderPage { get; set; } = string.Empty;

        public string[] TxtMenu { get; private set; } = new string[8];

        public string[] TxtButton { get; private set; } = new string[19];

        public string[] TxtTitle { get; private set; } = new string[48];

        public string[] TxtDateC { get; private set; } = new string[6];

        public string[] TxtText { get; private set; } = new string[87];

        public string[] TxtDone { get; private set; } = new string[14];

        public string[] TxtError { get; private set; } = new string[8];

        public event Action? OnChange;

        private void Menu_EN()
        {
            int i = 0;

            // 0
            TxtMenu[i] = "Home";
            i++;
            // 1
            TxtMenu[i] = "All courses";
            i++;
            // 2
            TxtMenu[i] = "Add course";
            i++;
            // 3
            TxtMenu[i] = "All teachers";
            i++;
            // 4
            TxtMenu[i] = "All students";
            i++;
            // 5
            TxtMenu[i] = "Unregistered";
            i++;
            // 6
            TxtMenu[i] = "Forum";
            i++;
            // 7
            TxtMenu[i] = "T E A C H E R";
        }

        private void Menu_SV()
        {
            int i = 0;

            // 0
            TxtMenu[i] = "Hem";
            i++;
            // 1
            TxtMenu[i] = "Alla kurser";
            i++;
            // 2
            TxtMenu[i] = "Lägg till kurs";
            i++;
            // 3
            TxtMenu[i] = "Alla lärare";
            i++;
            // 4
            TxtMenu[i] = "Alla elever";
            i++;
            // 5
            TxtMenu[i] = "Oregistrerade";
            i++;
            // 6
            TxtMenu[i] = "Forum";
            i++;
            // 7
            TxtMenu[i] = "L Ä R A R E";
        }

        private void Menu_DE()
        {
            // Deutsch
        }

        private void Menu_FR()
        {
            // Français
        }

        private void Button_EN() // 0 2 8 13 1 3 15 10 6 12 4 5 7
        {
            int i = 0;

            // 0
            TxtButton[i] = "Regret";
            i++;
            // 1
            TxtButton[i] = "Finish";
            i++;
            // 2
            TxtButton[i] = "Save";
            i++;
            // 3
            TxtButton[i] = "Save new type";
            i++;
            // 4
            TxtButton[i] = "Save and done";
            i++;
            // 5
            TxtButton[i] = "Save and add more modules";
            i++;
            // 6
            TxtButton[i] = "Save, but not this module";
            i++;
            // 7
            TxtButton[i] = "Save, but not this";
            i++;
            // 8
            TxtButton[i] = "Add module";
            i++;
            // 9
            TxtButton[i] = "Add activity";
            i++;
            // 10
            TxtButton[i] = "Add more activities";
            i++;
            // 11
            TxtButton[i] = "Add / edit activity types";
            i++;
            // 12
            TxtButton[i] = "Edit type";
            i++;
            // 13
            TxtButton[i] = "Register now!";
            i++;
            // 14
            TxtButton[i] = "Add/edit thread";
            i++;
            // 15
            TxtButton[i] = "Delete thread";
            i++;
            // 16
            TxtButton[i] = "Close";
            i++;
            // 17
            TxtButton[i] = "Save thread";
            i++;
            // 18
            TxtButton[i] = "Post!";
        }

        private void Button_SV()
        {
            int i = 0;

            // 0
            TxtButton[i] = "Ångra";
            i++;
            // 1
            TxtButton[i] = "Färdig";
            i++;
            // 2
            TxtButton[i] = "Spara";
            i++;
            // 3
            TxtButton[i] = "Spara ny typ";
            i++;
            // 4
            TxtButton[i] = "Spara och färdig";
            i++;
            // 5
            TxtButton[i] = "Spara och lägg till fler moduler";
            i++;
            // 6
            TxtButton[i] = "Spara, men inte den här modulen";
            i++;
            // 7
            TxtButton[i] = "Spara, men inte denna";
            i++;
            // 8
            TxtButton[i] = "Lägg till modul";
            i++;
            // 9
            TxtButton[i] = "Lägg till aktivitet";
            i++;
            // 10
            TxtButton[i] = "Lägg till fler aktiviteter";
            i++;
            // 11
            TxtButton[i] = "Lägg till / redigera aktivitetstyper";
            i++;
            // 12
            TxtButton[i] = "Redigera typ";
            i++;
            // 13
            TxtButton[i] = "Registrera nu!";
            i++;
            // 14
            TxtButton[i] = "Lägg till / redigera tråd";
            i++;
            // 15
            TxtButton[i] = "Ta bort tråd";
            i++;
            // 16
            TxtButton[i] = "Stäng";
            i++;
            // 17
            TxtButton[i] = "Spara tråd";
            i++;
            // 18
            TxtButton[i] = "Posta!";
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
            TxtTitle[i] = "Important information";
            i++;
            // 1
            TxtTitle[i] = "Add or delete avatar";
            i++;
            // 2
            TxtTitle[i] = "Eliminate all documents and messages";
            i++;
            // 3
            TxtTitle[i] = "Personal post";
            i++;
            // 4
            TxtTitle[i] = "-Click for edit-";
            i++;
            // 5
            TxtTitle[i] = "Delete course";
            i++;
            // 6
            TxtTitle[i] = "Add a blank module";
            i++;
            // 7
            TxtTitle[i] = "Avoid add course";
            i++;
            // 8
            TxtTitle[i] = "Save only this course";
            i++;
            // 9
            TxtTitle[i] = "To step 2: Add module";
            i++;
            // 10
            TxtTitle[i] = "Add or edit activity types";
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
            TxtTitle[i] = "Finish add or delete activity type";
            i++;
            // 15
            TxtTitle[i] = "Add this new activity type";
            i++;
            // 16
            TxtTitle[i] = "Edit this activity type";
            i++;
            // 17
            TxtTitle[i] = "To avoid entangled dates";
            i++;
            // 18
            TxtTitle[i] = "Avoid adding course with modules";
            i++;
            // 19
            TxtTitle[i] = "To step 3: Add activity";
            i++;
            // 20
            TxtTitle[i] = "Save course but not this module";
            i++;
            // 21
            TxtTitle[i] = "reserve";
            i++;
            // 22
            TxtTitle[i] = "reserve";
            i++;
            // 23
            TxtTitle[i] = "reserve";
            i++;
            // 24
            TxtTitle[i] = "Avoid adding course with modules and activities";
            i++;
            // 25
            TxtTitle[i] = "Add more activities";
            i++;
            // 26
            TxtTitle[i] = "Save and done";
            i++;
            // 27
            TxtTitle[i] = "Save this and add more modules";
            i++;
            // 28
            TxtTitle[i] = "Save earlier but not this activity";
            i++;
            // 29
            TxtTitle[i] = "Pagination settings";
            i++;
            // 30
            TxtTitle[i] = "Shortcut to the student page";
            i++;
            // 31
            TxtTitle[i] = "Add document to student";
            i++;
            // 32
            TxtTitle[i] = "reserve";
            i++;
            // 33
            TxtTitle[i] = "reserve";
            i++;
            // 34
            TxtTitle[i] = "Add/change course for student";
            i++;
            // 35
            TxtTitle[i] = "Delete or redirect user";
            i++;
            // 36
            TxtTitle[i] = "Add document to teacher";
            i++;
            // 37
            TxtTitle[i] = "Add/change course for teacher";
            i++;
            // 38
            TxtTitle[i] = "Not yet authorized student";
            i++;
            // 39
            TxtTitle[i] = "Mandatory thread";
            i++;
            // 40
            TxtTitle[i] = "Open this thread";
            i++;
            // 41
            TxtTitle[i] = "reserve";
            i++;
            // 42
            TxtTitle[i] = "reserve";
            i++;
            // 43
            TxtTitle[i] = "reserve";
            i++;
            // 44
            TxtTitle[i] = "Save this thread to your system";
            i++;
            // 45
            TxtTitle[i] = "Edit this post";
            i++;
            // 46
            TxtTitle[i] = "Number of edits for this post";
            i++;
            // 47
            TxtTitle[i] = "Up again";
        }

        private void Title_SV()
        {
            int i = 0;

            // 0
            TxtTitle[i] = "Viktig information";
            i++;
            // 1
            TxtTitle[i] = "Lägg till eller radera avatar";
            i++;
            // 2
            TxtTitle[i] = "Eliminera alla dokument och meddelanden";
            i++;
            // 3
            TxtTitle[i] = "Personlig post";
            i++;
            // 4
            TxtTitle[i] = "-Klicka för redigering-";
            i++;
            // 5
            TxtTitle[i] = "Ta bort kursen";
            i++;
            // 6
            TxtTitle[i] = "Lägg till en tom modul";
            i++;
            // 7
            TxtTitle[i] = "Undvik att lägga till kurs";
            i++;
            // 8
            TxtTitle[i] = "Spara endast denna kurs";
            i++;
            // 9
            TxtTitle[i] = "Till steg 2: Lägg till modul";
            i++;
            // 10
            TxtTitle[i] = "Lägg till eller redigera aktivitetstyper";
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
            TxtTitle[i] = "Slutför lägg till eller ta bort aktivitetstyp";
            i++;
            // 15
            TxtTitle[i] = "Lägg till den här nya aktivitetstypen";
            i++;
            // 16
            TxtTitle[i] = "Redigera den här aktivitetstypen";
            i++;
            // 17
            TxtTitle[i] = "För att undvika intrasslade datum";
            i++;
            // 18
            TxtTitle[i] = "Undvik att lägga till kurs med moduler";
            i++;
            // 19
            TxtTitle[i] = "Till steg 3: Lägg till aktivitet";
            i++;
            // 20
            TxtTitle[i] = "Spara kurs men inte denna modul";
            i++;
            // 21
            TxtTitle[i] = "reserve";
            i++;
            // 22
            TxtTitle[i] = "reserve";
            i++;
            // 23
            TxtTitle[i] = "reserve";
            i++;
            // 24
            TxtTitle[i] = "Undvik att lägga till kurs med moduler och aktiviteter";
            i++;
            // 25
            TxtTitle[i] = "Lägg till fler aktiviteter";
            i++;
            // 26
            TxtTitle[i] = "Spara och färdig";
            i++;
            // 27
            TxtTitle[i] = "Spara detta och lägg till fler moduler";
            i++;
            // 28
            TxtTitle[i] = "Spara tidigare men inte denna aktivitet";
            i++;
            // 29
            TxtTitle[i] = "Inställningar för personsökning";
            i++;
            // 30
            TxtTitle[i] = "Genväg till studentsidan";
            i++;
            // 31
            TxtTitle[i] = "Lägg till dokument till elev";
            i++;
            // 32
            TxtTitle[i] = "reserve";
            i++;
            // 33
            TxtTitle[i] = "reserve";
            i++;
            // 34
            TxtTitle[i] = "Lägg till/ändra kurs för elev";
            i++;
            // 35
            TxtTitle[i] = "Ta bort eller omdirigera användare";
            i++;
            // 36
            TxtTitle[i] = "Lägg till dokument till lärare";
            i++;
            // 37
            TxtTitle[i] = "Lägg till/ändra kurs för lärare";
            i++;
            // 38
            TxtTitle[i] = "Ännu inte behörig student";
            i++;
            // 39
            TxtTitle[i] = "Obligatorisk tråd";
            i++;
            // 40
            TxtTitle[i] = "Öppna den här tråden";
            i++;
            // 41
            TxtTitle[i] = "reserve";
            i++;
            // 42
            TxtTitle[i] = "reserve";
            i++;
            // 43
            TxtTitle[i] = "reserve";
            i++;
            // 44
            TxtTitle[i] = "Spara den här tråden i ditt system";
            i++;
            // 45
            TxtTitle[i] = "Redigera det här inlägget";
            i++;
            // 46
            TxtTitle[i] = "Antal redigeringar för detta inlägg";
            i++;
            // 47
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

        private void DateC_EN()
        {
            int i = 0;

            // 0
            TxtDateC[i] = "reserve";
            i++;
            // 1
            TxtDateC[i] = "Perform date check...";
            i++;
            // 2
            TxtDateC[i] = "Date mismatch (start date is greater than end date).";
            i++;
            // 3
            TxtDateC[i] = "Date mismatch (date is outside the course or the module date).";
            i++;
            // 4
            TxtDateC[i] = "Date mismatch (entangled dates).";
            i++;
            // 5
            TxtDateC[i] = "Cannot calculate (overloading).";
        }

        private void DateC_SV()
        {
            int i = 0;

            // 0
            TxtDateC[i] = "reserve";
            i++;
            // 1
            TxtDateC[i] = "Utför datumkontroll...";
            i++;
            // 2
            TxtDateC[i] = "Datumfel (startdatum är större än slutdatum).";
            i++;
            // 3
            TxtDateC[i] = "Datumfel (datum är utanför kurs eller moduldatum).";
            i++;
            // 4
            TxtDateC[i] = "Datumfel (intrasslade datum).";
            i++;
            // 5
            TxtDateC[i] = "Kan ej beräkna (överbelastning).";
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
            TxtText[i] = "Hello, ";
            i++;
            // 2
            TxtText[i] = "module";
            i++;
            // 3
            TxtText[i] = "modules";
            i++;
            // 4
            TxtText[i] = "participant";
            i++;
            // 5
            TxtText[i] = "participants";
            i++;
            // 6
            TxtText[i] = "document";
            i++;
            // 7
            TxtText[i] = "documents";
            i++;
            // 8
            TxtText[i] = "Add a course with modules and activities...";
            i++;
            // 9
            TxtText[i] = "Add course:";
            i++;
            // 10
            TxtText[i] = "reserve";
            i++;
            // 11
            TxtText[i] = "reserve";
            i++;
            // 12
            TxtText[i] = "reserve";
            i++;
            // 13
            TxtText[i] = "Name";
            i++;
            // 14
            TxtText[i] = "Description";
            i++;
            // 15
            TxtText[i] = "Start date";
            i++;
            // 16
            TxtText[i] = "End date";
            i++;
            // 17
            TxtText[i] = "Step 1 of 3";
            i++;
            // 18
            TxtText[i] = "Step 2 of 3";
            i++;
            // 19
            TxtText[i] = "Step 3 of 3";
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
            TxtText[i] = "Add or edit activity types:";
            i++;
            // 24
            TxtText[i] = "Type";
            i++;
            // 25
            TxtText[i] = "New";
            i++;
            // 26
            TxtText[i] = "Add module:";
            i++;
            // 27
            TxtText[i] = "Add activity:";
            i++;
            // 28
            TxtText[i] = "COURSE:";
            i++;
            // 29
            TxtText[i] = "Modules...";
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
            TxtText[i] = "Module name";
            i++;
            // 34
            TxtText[i] = "Module description";
            i++;
            // 35
            TxtText[i] = "Module date";
            i++;
            // 36
            TxtText[i] = "Activities for this module";
            i++;
            // 37
            TxtText[i] = "Activity name";
            i++;
            // 38
            TxtText[i] = "Activity type";
            i++;
            // 39
            TxtText[i] = "Activity description";
            i++;
            // 40
            TxtText[i] = "Activity date";
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
            TxtText[i] = "List of students";
            i++;
            // 45
            TxtText[i] = "List of teachers";
            i++;
            // 46
            TxtText[i] = "No students !";
            i++;
            // 47
            TxtText[i] = "No teachers !";
            i++;
            // 48
            TxtText[i] = "There is no student with that name...";
            i++;
            // 49
            TxtText[i] = "There is no teacher with that name...";
            i++;
            // 50
            TxtText[i] = "This student has now been updated...";
            i++;
            // 51
            TxtText[i] = "This teacher has now been updated...";
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
            TxtText[i] = "No courses !";
            i++;
            // 56
            TxtText[i] = "There is no course with that name...";
            i++;
            // 57
            TxtText[i] = "List of unregistered";
            i++;
            // 58
            TxtText[i] = "No unregistered !";
            i++;
            // 59
            TxtText[i] = "There is no visitor with that name...";
            i++;
            // 60
            TxtText[i] = "reserve";
            i++;
            // 61
            TxtText[i] = "reserve";
            i++;
            // 62
            TxtText[i] = "reserve";
            i++;
            // 63
            TxtText[i] = "Student";
            i++;
            // 64
            TxtText[i] = "Teacher";
            i++;
            // 65
            TxtText[i] = "Visitor";
            i++;
            // 66
            TxtText[i] = "Email";
            i++;
            // 67
            TxtText[i] = "Phone number";
            i++;
            // 68
            TxtText[i] = "Course";
            i++;
            // 69
            TxtText[i] = "No course yet...";
            i++;
            // 70
            TxtText[i] = "No course";
            i++;
            // 71
            TxtText[i] = "reserve";
            i++;
            // 72
            TxtText[i] = "SELECT A THREAD";
            i++;
            // 73
            TxtText[i] = "Your saved threads...";
            i++;
            // 74
            TxtText[i] = "“This post has been deleted” is displayed for 6 hours before the post disappears.";
            i++;
            // 75
            TxtText[i] = "Created by";
            i++;
            // 76
            TxtText[i] = " - Private";
            i++;
            // 77
            TxtText[i] = " - Mandatory";
            i++;
            // 78
            TxtText[i] = " - No restrictions";
            i++;
            // 79
            TxtText[i] = "Write a reply";
            i++;
            // 80
            TxtText[i] = "Replaces the name (red)";
            i++;
            // 81
            TxtText[i] = "reserve";
            i++;
            // 82
            TxtText[i] = "reserve";
            i++;
            // 83
            TxtText[i] = "reserve";
            i++;
            // 84
            TxtText[i] = "Discussion forum";
            i++;
            // 85
            TxtText[i] = "Forum is missing...";
            i++;
            // 86
            TxtText[i] = "No threads could be found...";
        }

        private void Text_SV()
        {
            int i = 0;

            // 0
            TxtText[i] = "reserve";
            i++;
            // 1
            TxtText[i] = "Hej, ";
            i++;
            // 2
            TxtText[i] = "modul";
            i++;
            // 3
            TxtText[i] = "moduler";
            i++;
            // 4
            TxtText[i] = "deltagare";
            i++;
            // 5
            TxtText[i] = "deltagare";
            i++;
            // 6
            TxtText[i] = "dokument";
            i++;
            // 7
            TxtText[i] = "dokument";
            i++;
            // 8
            TxtText[i] = "Lägg till en kurs med moduler och aktiviteter...";
            i++;
            // 9
            TxtText[i] = "Lägg till kurs:";
            i++;
            // 10
            TxtText[i] = "reserve";
            i++;
            // 11
            TxtText[i] = "reserve";
            i++;
            // 12
            TxtText[i] = "reserve";
            i++;
            // 13
            TxtText[i] = "Namn";
            i++;
            // 14
            TxtText[i] = "Beskrivning";
            i++;
            // 15
            TxtText[i] = "Startdatum";
            i++;
            // 16
            TxtText[i] = "Slutdatum";
            i++;
            // 17
            TxtText[i] = "Steg 1 av 3";
            i++;
            // 18
            TxtText[i] = "Steg 2 av 3";
            i++;
            // 19
            TxtText[i] = "Steg 3 av 3";
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
            TxtText[i] = "Lägg till eller redigera aktivitetstyper:";
            i++;
            // 24
            TxtText[i] = "Typ";
            i++;
            // 25
            TxtText[i] = "Ny";
            i++;
            // 26
            TxtText[i] = "Lägg till modul:";
            i++;
            // 27
            TxtText[i] = "Lägg till aktivitet:";
            i++;
            // 28
            TxtText[i] = "KURS:";
            i++;
            // 29
            TxtText[i] = "Moduler...";
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
            TxtText[i] = "Modulnamn";
            i++;
            // 34
            TxtText[i] = "Modulbeskrivning";
            i++;
            // 35
            TxtText[i] = "Moduldatum";
            i++;
            // 36
            TxtText[i] = "Aktiviteter för denna modul";
            i++;
            // 37
            TxtText[i] = "Aktivitetsnamn";
            i++;
            // 38
            TxtText[i] = "Aktivitetstyp";
            i++;
            // 39
            TxtText[i] = "Aktivitetsbeskrivning";
            i++;
            // 40
            TxtText[i] = "Aktivitetsdatum";
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
            TxtText[i] = "Listning av elever";
            i++;
            // 45
            TxtText[i] = "Listning av lärare";
            i++;
            // 46
            TxtText[i] = "Inga elever !";
            i++;
            // 47
            TxtText[i] = "Inga lärare !";
            i++;
            // 48
            TxtText[i] = "Det finns ingen elev med det namnet...";
            i++;
            // 49
            TxtText[i] = "Det finns ingen lärare med det namnet...";
            i++;
            // 50
            TxtText[i] = "Denna elev har nu uppdaterats...";
            i++;
            // 51
            TxtText[i] = "Denna lärare har nu uppdaterats...";
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
            TxtText[i] = "Inga kurser !";
            i++;
            // 56
            TxtText[i] = "Det finns ingen kurs med det namnet...";
            i++;
            // 57
            TxtText[i] = "Listning av oregistrerade";
            i++;
            // 58
            TxtText[i] = "Inga oregistrerade !";
            i++;
            // 59
            TxtText[i] = "Det finns ingen besökare med det namnet...";
            i++;
            // 60
            TxtText[i] = "reserve";
            i++;
            // 61
            TxtText[i] = "reserve";
            i++;
            // 62
            TxtText[i] = "reserve";
            i++;
            // 63
            TxtText[i] = "Elev";
            i++;
            // 64
            TxtText[i] = "Lärare";
            i++;
            // 65
            TxtText[i] = "Besökare";
            i++;
            // 66
            TxtText[i] = "E-post";
            i++;
            // 67
            TxtText[i] = "Telefonnummer";
            i++;
            // 68
            TxtText[i] = "Kurs";
            i++;
            // 69
            TxtText[i] = "Ingen kurs ännu...";
            i++;
            // 70
            TxtText[i] = "Ingen kurs";
            i++;
            // 71
            TxtText[i] = "reserve";
            i++;
            // 72
            TxtText[i] = "VÄLJ EN TRÅD";
            i++;
            // 73
            TxtText[i] = "Dina sparade trådar...";
            i++;
            // 74
            TxtText[i] = "”Detta inlägg har tagits bort” visas i 6 timmar innan inlägget försvinner.";
            i++;
            // 75
            TxtText[i] = "Skapad av";
            i++;
            // 76
            TxtText[i] = " - Privat";
            i++;
            // 77
            TxtText[i] = " - Obligatorisk";
            i++;
            // 78
            TxtText[i] = " - Inga restriktioner";
            i++;
            // 79
            TxtText[i] = "Skriv ett inlägg";
            i++;
            // 80
            TxtText[i] = "Ersätter namnet (rött)";
            i++;
            // 81
            TxtText[i] = "reserve";
            i++;
            // 82
            TxtText[i] = "reserve";
            i++;
            // 83
            TxtText[i] = "reserve";
            i++;
            // 84
            TxtText[i] = "Diskussionsforum";
            i++;
            // 85
            TxtText[i] = "Forum saknas...";
            i++;
            // 86
            TxtText[i] = "Inga trådar kunde hittas...";
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
            TxtDone[i] = "This course was deleted.";
            i++;
            // 2
            TxtDone[i] = "An empty module was added.";
            i++;
            // 3
            TxtDone[i] = "Finish add or edit activity types.";
            i++;
            // 4
            TxtDone[i] = "Your course is created.";
            i++;
            // 5
            TxtDone[i] = "The course was NOT edited or created.";
            i++;
            // 6
            TxtDone[i] = "This visitor was registered. Press “Search” for refreshing.";
            i++;
            // 7
            TxtDone[i] = "The thread is saved.";
            i++;
            // 8
            TxtDone[i] = "The thread is already saved.";
            i++;
            // 9
            TxtDone[i] = "No content no post.";
            i++;
            // 10
            TxtDone[i] = "Thumbs UP for this.";
            i++;
            // 11
            TxtDone[i] = "Thumbs down for this.";
            i++;
            // 12
            TxtDone[i] = "You changed your mind.";
            i++;
            // 13
            TxtDone[i] = "One is enough!";
        }

        private void Done_SV()
        {
            int i = 0;

            // 0
            TxtDone[i] = "reserve";
            i++;
            // 1
            TxtDone[i] = "Den här kursen togs bort.";
            i++;
            // 2
            TxtDone[i] = "En tom modul lades till.";
            i++;
            // 3
            TxtDone[i] = "Lägga till eller redigera aktivitetstyper är slutfört.";
            i++;
            // 4
            TxtDone[i] = "Din kurs är skapad.";
            i++;
            // 5
            TxtDone[i] = "Kursen har INTE redigerats eller skapats.";
            i++;
            // 6
            TxtDone[i] = "Denna besökare registrerades. Tryck på ”Search” för att uppdatera.";
            i++;
            // 7
            TxtDone[i] = "Tråden är sparad.";
            i++;
            // 8
            TxtDone[i] = "Tråden är redan sparad.";
            i++;
            // 9
            TxtDone[i] = "Inget innehåll inget inlägg.";
            i++;
            // 10
            TxtDone[i] = "Tumme UPP för denna.";
            i++;
            // 11
            TxtDone[i] = "Tumme ned för denna.";
            i++;
            // 12
            TxtDone[i] = "Du ändrade dig.";
            i++;
            // 13
            TxtDone[i] = "En räcker!";
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
            TxtError[i] = "All modules, activities, documents, messages, and users belonging to a course" +
                          " must first be deleted or redirected before a course can be deleted.";
            i++;
            // 2
            TxtError[i] = "Course date mismatch (start date is greater than end date).";
            i++;
            // 3
            TxtError[i] = "The Name field is required.";
            i++;
            // 4
            TxtError[i] = "The Description field is required.";
            i++;
            // 5
            TxtError[i] = "The Name and Description fields are required.";
            i++;
            // 6
            TxtError[i] = "You are not authorized to write in this thread.";
            i++;
            // 7
            TxtError[i] = "The thread cannot be found.";
        }

        private void Error_SV()
        {
            int i = 0;

            // 0
            TxtError[i] = "reserve";
            i++;
            // 1
            TxtError[i] = "Alla moduler, aktiviteter, dokument, meddelanden och användare som hör till en kurs" +
                          " måste först raderas eller omdirigeras innan en kurs kan tas bort.";
            i++;
            // 2
            TxtError[i] = "Kursdatum är felaktigt (startdatum är större än slutdatum).";
            i++;
            // 3
            TxtError[i] = "Namn är obligatoriskt.";
            i++;
            // 4
            TxtError[i] = "Beskrivning är obligatoriskt.";
            i++;
            // 5
            TxtError[i] = "Namn och beskrivning är obligatoriskt.";
            i++;
            // 6
            TxtError[i] = "Du är inte behörig att skriva i denna tråd.";
            i++;
            // 7
            TxtError[i] = "Tråden går inte att hitta.";
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
            RenderPage = "STILL_HERE";
            Menu_EN();
            Button_EN();
            Title_EN();
            DateC_EN();
            Text_EN();
            Done_EN();
            Error_EN();
            NotifyStateChanged();
        }

        public void SetMenu_EN()
        {
            Menu_EN();
            NotifyStateChanged();
        }

        public void SetLanguage_SV()
        {
            RenderPage = "STILL_HERE";
            Menu_SV();
            Button_SV();
            Title_SV();
            DateC_SV();
            Text_SV();
            Done_SV();
            Error_SV();
            NotifyStateChanged();
        }

        public void SetMenu_SV()
        {
            Menu_SV();
            NotifyStateChanged();
        }

        public void SetLanguage_DE()
        {
            RenderPage = "STILL_HERE";
            Menu_DE();
            Button_DE();
            Title_DE();
            DateC_DE();
            Text_DE();
            Done_DE();
            Error_DE();
            NotifyStateChanged();
        }

        public void SetMenu_DE()
        {
            Menu_DE();
            NotifyStateChanged();
        }

        public void SetLanguage_FR()
        {
            RenderPage = "STILL_HERE";
            Menu_FR();
            Button_FR();
            Title_FR();
            DateC_FR();
            Text_FR();
            Done_FR();
            Error_FR();
            NotifyStateChanged();
        }

        public void SetMenu_FR()
        {
            Menu_FR();
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}