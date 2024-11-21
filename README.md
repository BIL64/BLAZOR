# LexiconLMSBlazor
Lexicon LMS (Learning Management System)
Version 1.19 NET9

Det avslutande projektet för .NET IT-utbildningen vid Lexicon (221025-230421) som jag och mina klasskamrater gjorde var ett grupparbete. Vi skulle bygga en lärplattform som förenklar och centraliserar kommunikationen mellan lärare, lärosäte och elev genom att samla schema, kursmaterial, övrig information, övningsuppgifter och inlämningar på ett och samma ställe. Att från grunden producera systemet med databas, back-end funktionalitet och ett genomtänkt frontend. Detta kallas ett "full-stack projekt" och syftar till att visa upp vår förståelse för samtliga delar av en webbapplikation och nutida system. Projektet ämnar testa bredden av vår förståelse, så att vi har en grund att stå på oavsett framtida inriktning inom .NET.

Förenklat kan man säga att projektet är en hemsida där det första som dyker upp är en presentation av deltagarens kurs i form av moduler och aktiviteter i kronologisk ordning, samt där man kan ta del av och även skicka dokument. Utöver detta finns kurskamraterna listade och ett diskussionsforum.

En bit in i projektets genomförande märkte jag att gruppen började avvika från den wire-frame som vi från början hade tänkt ut gemensamt. Jag kunde dock inte se hur dessa avvikelser skulle kunna leda oss till ett färdigt fungerande system, vilket försvårade eller omöjliggjorde färdigställandet av projektet, eller att det skulle leda till akut tidsbrist om det tilläts fortsätta. Då valde jag att själv bygga färdigt projektet efter eget huvud, så att vi fick två versioner eller varianter och som vi kunde visa upp. På redovisningsdagen visades alltså både gruppens lösning och min lösning, vilket togs emot med blandade reaktioner.

Detta är alltså variant två och som jag anser är ett fungerande LMS. Vi beslöt att bygga efter en Blazor WebAssembly App med ett API och med en "ASP.NET Core Hosted". Därtill, med autentisering i form av "Individual Accounts". Av vad jag kan förstå täcker min lösning in hela kravspecen.

Så här några månader efteråt har en hel del förbättringar genomförts:

•	Flexiblare hantering av moduler såsom placering, utseende, innehåll och status.

•	Det går att ändra, bygga vidare, kopiera, flytta eller döpa om en redan skapad kurs. 

•	Meddelanderuta för info, feedback, postmeddelanden och fel (error).

•	Kraftfulla sökfunktioner.

•	Fullt fungerande dokumenthantering och möjlighet att välja avatarer.

•	Paginering (personsökning) för både studenter och lärare.

•	Förbättrade Toasts som går att flytta med musen.

•	En Options eller ett fönster där man kan välja övergripande inställningar såsom aktivering för registrering, språkval, färgval mm.

•	Och till sist ett diskussionsforum som gör det hela tillämpningsbart.

Avsaknaden av mobilanpassning är en nackdel men det gäller inte här. Det första man möts av är ett notishäfte, där man kan göra anteckningar om sådant som är viktigt att komma ihåg. Man kan se denna LMS som en fattigmans Teams. Det finns exempelvis inga möjligheter att kommunicera med ljud och bild via dator/mobil, eller att kunna fjärrstyra studenternas dator etc.
