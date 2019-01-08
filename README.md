#### ALWAYS PULL FIRST THEN WORK THEN PUSH

# DBS-Projekt

## Arbeitsteilung

### Gruppe GUI + Datenbank Grundstruktur

#### Alireza, Sina, Markus Krenn

#### Fortschritt:
* Datenbankgrundstruktur fertig.
* Datenbankanbindung (Windows Authentifizierung und SQL Login) fertig.
* Erste Windows Forms fertig.
* Main Menu fertig
* Angestellte fehlt nur mehr Update
* 
* 
* 

#### Arbeitspakete
```
DBS_GUI


form                            designed by       Fortschritt
---------------------------------------------------------------

mainMenu                        Markus                   100%

viewAngestellte                 Markus                   100%
addAngestellte                  Markus                   100%
updateAngestellte               Markus                   100%

Projektteilnehmer               Markus                     0%

viewAbteilung                   Alireza                  100%
addAbteilung                    Alireza                  100%
updateAbteilung                 Alireza                  100%
deactivateAbteilung             Alireza                  100%

viewNiederlassung               Alireza                  100%
addNiederlassung                Alireza                   50%
updateNiederlassung             Alireza                   50%
deactivateNiederlassung         Alireza                    0%


viewProjekt                     Sina                     100%
addProjekt                      Sina                     100%
updateProjekt                   Sina                     100%
deactivateProjekt               Sina                     100%

viewBestellungen                Sina                     100%
addBestelleung                  Sina                     100%

viewKunde                       Sina                     100%
addKunde                        Sina                     100%
updateKunde                     Sina                     100%
deactivateKunde                 Sina                     100%
```

* einmal generierte Bestellungen werden aus Datenschutzgründen nicht geändert/gelöscht!
* View und Update bei Projektteilnehmer in einer Form?
---

### GIT CONFIGURATION

### Alireza Esbati

---

### Gruppe SQL

#### Ervin, Markus Koller

#### Fortschritt:
* 8 Stored Procedures (test error, Angestellte, Projekte)   100%
* 1 View (showAngestellteNicely)                            100%
* einen Test user erstellt (user="maxi" pwd="1234")         100%

> see 'markuskrenn.sql'

* 
* 
* 


#### Arbeitspakete
```
Stored Procedures         pro User Form ~1 Procedure
min. 2 Trigger            (z.B.: update Angestellte, update Rechnungspreis)
min. 2 Views              (z.B.: Rechnung, showAngestellteNicely)
min. 2 Cursor             ???
min. 2 Indexe             ???

Error Handling !!!
```

---

## Abgabe: 9.1.2019 !!!
