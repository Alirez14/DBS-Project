##### ALWAYS PULL FIRST THEN WORK THEN PUSH

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
updateAngestellte               Markus                     0%

Projektteilnehmer               Markus                    10%

viewAbteilung                   Alireza                  100%
addAbteilung                    Alireza                   50%
updateAbteilung                 Alireza                   50%
deactivateAbteilung             Alireza                    0%

viewNiederlassung               Alireza                  100%
addNiederlassung                Alireza                   50%
updateNiederlassung             Alireza                   50%
deactivateNiederlassung         Alireza                    0%


viewProjekt                     Sina                       0%
addProjekt                      Sina                       0%
updateProjekt                   Sina                       0%
deactivateProjekt               Sina                       0%

viewBestellungen                Sina                       0%
addBestelleung                  Sina                       0%

viewKunde                       Sina                       0%
addKunde                        Sina                       0%
updateKunde                     Sina                       0%
deactivateKunde                 Sina                       0%
```

* einmal generierte Bestellungen werden aus Datenschutzgründen nicht geändert/gelöscht!
* View und Update bei Projektteilnehmer in einer Form?


---

### Gruppe SQL

#### Ervin, Markus Koller

#### Fortschritt:
* 6 Stored Procedures (test error, Angestellte, Projekte)   100%
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
