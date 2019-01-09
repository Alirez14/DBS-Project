--view for female employees

GO

CREATE OR ALTER VIEW wAngestellte AS
SELECT Nachname, Vorname, Sex FROM Angestellte
WHERE Sex = 'F';
GO

--view for male employees

CREATE OR ALTER VIEW mAngestellte AS
SELECT Nachname, Vorname, Sex FROM Angestellte
WHERE Sex = 'M';
GO

CREATE VIEW Kunde_TelefonNummer_VIEW AS
SELECT  Vorname, Nachname, Telefon
FROM  Kunde;
GO

--SELECT * FROM Kunde_TelefonNummer_VIEW

CREATE VIEW AbteilungInfo_VIEW AS
SELECT  Name, Email, Telefon
FROM  Abteilung;
GO


--SELECT * FROM AbteilungInfo_VIEW

--stored procedure for listing all employees matching the @Vorname / @Nachname input

GO  

DROP PROCEDURE IF EXISTS uspSearchAngestellte;
GO
CREATE PROCEDURE uspSearchAngestellte 
    (
		@Nachname VARCHAR(65) = NULL,
        @Vorname VARCHAR(65) = NULL
	)
	 
AS  

	BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	
		BEGIN TRY
		
			IF (@Nachname = NULL OR @Nachname = '') AND (@Vorname = NULL OR @Vorname = '')
				THROW 50001, 'Es wurde weder Vorname noch Nachname angegeben', 1
				
			IF ( LEN(@Nachname) > 64 OR LEN(@Vorname) > 64 )
				THROW 50002, 'Namen können nicht länger als 64 Zeichen lang sein', 1
				
			IF (SELECT COUNT(*) FROM Angestellte WHERE (@Nachname IS NULL OR Nachname LIKE '%' + @Nachname + '%') AND (@Vorname IS NULL OR Vorname LIKE '%' + @Vorname + '%')) = 0
				THROW 50003, 'Es konnte keine Person mit gegebenen Vor-/Nachnamen gefunden werden' , 1
		
			SELECT * FROM Angestellte
			WHERE (@Nachname IS NULL OR Nachname LIKE '%' + @Nachname + '%')
			AND (@Vorname IS NULL OR Vorname LIKE '%' + @Vorname + '%');
			
			-- ROLLBACK
			COMMIT
			
		END TRY
		
		BEGIN CATCH
			
			SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
			ROLLBACK
			
		END CATCH
		
GO  

 EXECUTE uspSearchAngestellte @Vorname = 'Alireza', @Nachname = 'Esbati'; 
 GO

-- stored procedure for viewing a Projekt

GO  

DROP PROCEDURE IF EXISTS uspGetProjekt;
GO
CREATE PROCEDURE uspGetProjekt
(@Name VARCHAR(MAX) = NULL)
     
AS  
	BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
		BEGIN TRY
		
			IF (select COUNT(*) from Projekt where @Name = Name) = 0
				THROW 50004, 'Dieses Projekt existiert nicht' , 1;
			
			SELECT * FROM Projekt
			WHERE @Name = Name;
			
			-- ROLLBACK
			COMMIT
			
		END TRY
		
		BEGIN CATCH
		
			SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
			ROLLBACK
			
		END CATCH
GO  

--EXEC uspGetProjekt 'Proj';
--GO

-- -- Trigger: Update Anzahl Angestellte on INSERT (New employee)

-- DROP TRIGGER IF EXISTS trgUpdateAnzahlOnInsert
-- GO

-- CREATE TRIGGER trgUpdateAnzahlOnInsert
-- ON Angestellte AFTER INSERT
-- AS
	-- BEGIN
	
		-- IF (CURSOR_STATUS('global', 'csrUpdateAnzahlAngestellte') >= -1)	-- deallocates cursor if it exists
			-- DEALLOCATE csrUpdateAnzahlAngestellte;
			
		-- DECLARE csrUpdateAnzahlAngestellte CURSOR FAST_FORWARD FOR (SELECT FK_Abt_nr FROM INSERTED)
		-- DECLARE @abtNr INTEGER 

		-- OPEN csrUpdateAnzahlAngestellte 
		-- FETCH NEXT FROM csrUpdateAnzahlAngestellte INTO @abtNr
		
		-- IF @@FETCH_STATUS <> 0	-- rolls back transaction and throws error-message if inserted-table does not contain any rows
		-- BEGIN
			-- THROW 50004, 'trgUpdateAnzahlOnInsert_Error: Es konnten keine neuen Zeilen gefunden werden', 1
		-- END

		-- WHILE @@FETCH_STATUS = 0 
		-- BEGIN 

			-- UPDATE Abteilung 
			-- SET Anzahl_Angestellte += 1
			-- WHERE PK_Abt_Nr = @abtNr;
			
			-- FETCH NEXT FROM csrUpdateAnzahlAngestellte INTO @abtNr  
		-- END

		-- CLOSE csrUpdateAnzahlAngestellte
		-- DEALLOCATE csrUpdateAnzahlAngestellte
		
	-- END
-- GO

-- Trigger: Update Anzahl Angestellte on INSERT/DELETE

DROP TRIGGER IF EXISTS trgUpdateAnzahlOnEmployee
GO

CREATE TRIGGER trgUpdateAnzahlOnEmployee
ON Angestellte AFTER INSERT, DELETE
AS
	BEGIN
	
		IF (CURSOR_STATUS('global', 'csrUpdateAnzahlAngestellte') >= -1)	-- deallocates cursor if it exists
			DEALLOCATE csrUpdateAnzahlAngestellte;
				
		DECLARE @abtNr INTEGER
		DECLARE @var INTEGER = 0
		
		IF ((SELECT COUNT(*) FROM INSERTED) > 0 )
		BEGIN
			DECLARE csrUpdateAnzahlAngestellte CURSOR FAST_FORWARD FOR (SELECT FK_Abt_nr FROM INSERTED)
			SET @var = 1;
		END
		
		ELSE
		BEGIN
			DECLARE csrUpdateAnzahlAngestellte CURSOR FAST_FORWARD FOR (SELECT FK_Abt_nr FROM DELETED)
			SET @var = -1;
		END

		
		OPEN csrUpdateAnzahlAngestellte 
		FETCH NEXT FROM csrUpdateAnzahlAngestellte INTO @abtNr
		
		IF @@FETCH_STATUS <> 0	-- rolls back transaction and throws error-message if deleted-table does not contain any rows
		BEGIN
			;THROW 50014, 'trgUpdateAnzahlOnEmployee_Error: Es konnten keine neuen/gelöschten Zeilen gefunden werden', 1
		END

		WHILE @@FETCH_STATUS = 0 
		BEGIN 

			UPDATE Abteilung 
			SET Anzahl_Angestellte += @var
			WHERE PK_Abt_Nr = @abtNr;
			
			IF ((SELECT Anzahl_Angestellte FROM Abteilung WHERE PK_Abt_Nr = @abtNr) < 0)	-- passt so?
			BEGIN
				;THROW 50015, 'trgUpdateAnzahlOnEmployee_Error: Anzahl_Angestellte kleiner als 0', 1
			END
			
			FETCH NEXT FROM csrUpdateAnzahlAngestellte INTO @abtNr  
		END

		
		CLOSE csrUpdateAnzahlAngestellte
		DEALLOCATE csrUpdateAnzahlAngestellte
		
	END
GO

--TEST
--INSERT INTO Angestellte (Sex, Vorname, Nachname, Email, Gehalt, FK_FirmaID, FK_Abt_nr)
--	VALUES ('M', 'Testus', 'Testinger', 'test@mail.at', 999, 2, 3),
--			('M', 'Testus2', 'Testinger2', 'test2@mail.at', 999, 2, 3),
--			('M', 'Testus3', 'Testinger3', 'test3@mail.at', 999, 2, 2);

--DELETE FROM Angestellte WHERE Vorname LIKE 'Testus%' and Nachname LIKE 'Testinger%';

--SELECT * FROM Abteilung;


-- Trigger: Update Anzahl Angestellte on UPDATE (Switch department)

DROP TRIGGER IF EXISTS trgUpdateAnzahlOnEdit
GO

CREATE TRIGGER trgUpdateAnzahlOnEdit
ON Angestellte AFTER UPDATE
AS
	BEGIN
	
		IF ((SELECT FK_Abt_nr FROM INSERTED) <> (SELECT FK_Abt_nr FROM DELETED))
		BEGIN
			
			IF ((SELECT COUNT(*) FROM INSERTED) > 1)
				THROW 50005, 'trgUpdateAnzahlOnUpdate_Error: Es können nicht mehr als 1 Zeile pro UPDATE-Statement geupdated werden', 1
	
			DECLARE @abtNrNew INTEGER = (SELECT FK_Abt_nr FROM INSERTED)
			DECLARE @abtNrOld INTEGER = (SELECT FK_Abt_nr FROM DELETED)

			UPDATE Abteilung 
			SET Anzahl_Angestellte += 1
			WHERE PK_Abt_Nr = @abtNrNew;
			
			UPDATE Abteilung 
			SET Anzahl_Angestellte -= 1
			WHERE PK_Abt_Nr = @abtNrOld;
			
		END
		
	END
GO

--TEST
--SELECT * FROM Abteilung;

--UPDATE Angestellte
--SET FK_Abt_nr = 5 WHERE Vorname = 'Testus';


-- Trigger: Toggle active on Abteilung

DROP TRIGGER IF EXISTS trgAbteilungActive
GO

CREATE TRIGGER trgAbteilungActive
ON Abteilung AFTER UPDATE
AS
	BEGIN
	
		IF ((SELECT Anzahl_Angestellte FROM INSERTED) <> (SELECT Anzahl_Angestellte FROM DELETED))
		BEGIN
			
			IF ((SELECT COUNT(*) FROM INSERTED) > 1)
				THROW 50005, 'trgUpdateAnzahlOnUpdate_Error: Es können nicht mehr als 1 Zeile pro UPDATE-Statement geupdated werden', 1
	
			UPDATE Abteilung
			SET active = CASE 	WHEN Anzahl_Angestellte = 0 THEN 0
								ELSE 1
			END
			
		END
		
	END
GO

--TEST
--DELETE FROM Angestellte WHERE FK_Abt_nr = 4;


--Angestellte trigger

drop trigger if exists Atig;
go
create trigger Atig on Angestellte after insert
  as
  begin
select * from Angestellte where PK_AngID=(select PK_AngID from inserted)
    end

go

--Kunde trigger

drop trigger if exists Ktig;
go
create trigger Ktig on Kunde after insert
  as
  begin
select * from Kunde where PK_KundID=(select PK_KundID from inserted)
    end

GO  

-- Find an existing index named ix_BestellungProjektID and delete it if found.   
IF EXISTS (SELECT name FROM sys.indexes  
            WHERE name = N'ix_BestellungProjektID')   
    DROP INDEX ix_BestellungProjektID ON Bestellung;   
GO  

CREATE INDEX ix_BestellungProjektID   
    ON Bestellung (FK_Proj);   
GO  

GO  

-- Find an existing index named ix_BestellungKundeID and delete it if found.   
IF EXISTS (SELECT name FROM sys.indexes  
            WHERE name = N'ix_BestellungKundeID')   
    DROP INDEX ix_BestellungKundeID ON Bestellung;   
GO  

CREATE INDEX ix_BestellungKundeID   
    ON Bestellung (FK_Kunde);   
GO  