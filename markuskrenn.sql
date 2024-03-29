USE Unternehm

-- -----------------------------------------------------------
-- add new Angestellte
DROP PROCEDURE IF EXISTS uspAddNewAngestellten;
GO
CREATE PROCEDURE uspAddNewAngestellten
	@Sex VARCHAR(1),
	@Vorname VARCHAR(64),
	@Nachname VARCHAR(64),
	@Email VARCHAR(128),
	@Gehalt INT,
	@FirmaID INT,
	@Abt_nr INT
AS
BEGIN
	INSERT INTO Angestellte (Sex, Vorname, Nachname, Email, Gehalt, FK_FirmaID, FK_Abt_nr)
	VALUES (@Sex, @Vorname, @Nachname, @Email, @Gehalt, @FirmaID, @Abt_nr);
	
	RETURN SELECT count(*) FROM Angestellte
	WHERE Sex = @Sex AND Vorname = @Vorname AND Nachname = @Nachname
		AND Email = @Email AND Gehalt = @Gehalt AND FK_FirmaID = @FirmaID AND FK_Abt_nr = @Abt_nr;
END
-- example:
-- EXECUTE uspAddNewAngestellten @Sex='M', @Vorname='Markus', @Nachname='Krenn', @Email=NULL, @Gehalt=3000, @FirmaID=3, @Abt_nr=1;
-- SELECT * FROM Angestellte;
-- DELETE FROM Angestellte WHERE Vorname='Markus' and Nachname='Krenn';


-- -----------------------------------------------------------
-- get ALL Angestellten data for id:
DROP PROCEDURE IF EXISTS uspGetAllAngestellenDataForId;
GO
CREATE PROCEDURE uspGetAllAngestellenDataForId
	@Id INT
AS
BEGIN
	SELECT PK_AngID AS id, Sex, Vorname, Nachname, Email, Gehalt, FK_FirmaID, FK_Abt_nr, active 
	FROM Angestellte
	WHERE PK_AngID = @Id;
END
-- EXEC uspGetAllAngestellenDataForId @Id = 3;
SELECT * FROM Angestellte

-- -----------------------------------------------------------
-- edit Angestellte
DROP PROCEDURE IF EXISTS uspEditAngestellten;
GO
CREATE PROCEDURE uspEditAngestellten
	@Id INT,
	@active BIT,
	@Sex VARCHAR(1),
	@Vorname VARCHAR(64),
	@Nachname VARCHAR(64),
	@Email VARCHAR(128),
	@Gehalt INT,
	@FirmaID INT,
	@Abt_nr INT
AS
BEGIN
	UPDATE Angestellte
	SET Sex = @Sex, Vorname = @Vorname, Nachname = @Nachname,
		Email = @Email, Gehalt = @Gehalt, FK_FirmaID = @FirmaID, FK_Abt_nr = @Abt_nr,
		active = @active
	WHERE PK_AngID = @Id;
END


-- -----------------------------------------------------------
-- get all projects
DROP PROCEDURE IF EXISTS uspGetProjekte;
GO
CREATE PROCEDURE uspGetProjekte
AS
BEGIN
	SELECT PK_Proj_nr AS id, Name AS Projektname, Start_Date, End_Date FROM Projekt;
END
GO
-- EXECUTE uspGetProjekte;


-- -----------------------------------------------------------
-- view for Projektteilnehmer
DROP VIEW IF EXISTS viewAngestellte;
GO
CREATE VIEW viewAngestellte (id, Angestellter, Email, Gehalt, Niederlassung, Abteilung, aktiv) AS (
	SELECT
		PK_AngID AS id,
		Vorname + ' ' + Nachname AS Angestellter,
		Angestellte.Email AS Email,
		Gehalt,
		Niederlassung.Ort AS Niederlassung,
		Abteilung.Name AS Abteilung,
		Angestellte.active AS aktiv
	FROM Angestellte
		JOIN Niederlassung ON PK_FirmaID = FK_FirmaID
		JOIN Abteilung ON PK_Abt_nr = FK_Abt_nr
);
GO
-- SELECT * FROM viewAngestellte;


-- -----------------------------------------------------------
-- get all Angestellte nicely
DROP PROCEDURE IF EXISTS uspGetAngestellteFilteredNicely;
GO
CREATE PROCEDURE uspGetAngestellteFilteredNicely
	@name VARCHAR(128),
	@active int
AS
BEGIN
	IF @active = 0
		SELECT id, Angestellter, Email, Gehalt, Niederlassung, Abteilung
		FROM viewAngestellte
		WHERE Angestellter LIKE '%'+@name+'%' AND aktiv = 'True';

	ELSE
		SELECT id, Angestellter, Email, Gehalt, Niederlassung, Abteilung, aktiv
		FROM viewAngestellte
		WHERE Angestellter LIKE '%'+@name+'%';

END
GO
-- EXECUTE uspGetAngestellteFilteredNicely @name = '', @active=0;


-- -----------------------------------------------------------
-- get Angestellte for Projekt:
DROP PROCEDURE IF EXISTS uspGetAngestellteForProjektNicely;
GO
CREATE PROCEDURE uspGetAngestellteForProjektNicely
	@projekt VARCHAR(128)
AS
BEGIN
	SELECT Angestellter -- SELECT *
		FROM viewAngestellte
			JOIN Pro_Ang ON id = FK_AngID
			JOIN Projekt ON FK_Proj_nr = PK_Proj_nr
		WHERE Projekt.name = @Projekt
		ORDER BY Angestellter;
END
GO
-- EXECUTE uspGetAngestellteForProjektNicely @Projekt='Proj3';


-- -----------------------------------------------------------
-- add new Projektteilnehmer:
DROP PROCEDURE IF EXISTS uspAddTeilnehmer;
GO
CREATE PROCEDURE uspAddTeilnehmer
	@name	   VARCHAR(128),
	@projekt   VARCHAR(128)
AS
BEGIN
	INSERT INTO Pro_Ang (FK_AngID , FK_Proj_nr)
	VALUES (
		(SELECT id FROM viewAngestellte WHERE Angestellter = @name),
		(SELECT PK_Proj_nr FROM Projekt WHERE Name = @projekt)
	);
END
GO
-- example:
-- EXECUTE uspAddTeilnehmer @name='Markus Krenn', @projekt='Proj3';
-- DELETE FROM Pro_Ang
-- SELECT * FROM Pro_Ang;


-- -----------------------------------------------------------
-- procedure for test error:
CREATE OR ALTER PROCEDURE uspTesterror
AS
	RAISERROR('This is a test error!', 16, 0);
	--THROW 52000, 'This is a test error', 27;

-- RAISEEROR (<error message/text>, <SEVERITY/int>, <STATE/int>);
-- THROW <MsgID/int>, <error message/text>, <STATE/int>;
--    SEVERITY values between 11 and 16 are errors that can be corrected by the user
--    MsgID >= 50000 !

-- EXECUTE uspTesterror

-- -----------------------------------------------------------
-- User:
GO
DROP LOGIN maxi;
DROP USER maxi;
GO
CREATE LOGIN maxi WITH PASSWORD = '1234'
GO
CREATE USER maxi;
GO
DENY ALL ON DATABASE::Unternehm TO maxi;
GRANT INSERT, UPDATE, CREATE PROCEDURE, EXECUTE, CREATE VIEW, ALTER, CONTROL ON DATABASE::Unternehm TO maxi; 
GO
