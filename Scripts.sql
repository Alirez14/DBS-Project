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

CREATE PROCEDURE uspSearchAngestellte 
    (
		@Nachname VARCHAR(MAX) = NULL,
        @Vorname VARCHAR(MAX) = NULL
	)
	 
AS  

	BEGIN TRANSACTION
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	
		BEGIN TRY
		
			IF (@Nachname = NULL OR @Nachname = '') AND (@Vorname = NULL OR @Vorname = '')
				THROW 50001, 'Es wurde weder Vorname noch Nachname angegeben', 1
				
			IF ( LEN(@Nachname) > 64 OR LEN(@Vorname) > 64 )
				THROW 50002, 'Namen können nicht länger als 64 Zeichen lang sein', 1
				
			IF (@Vorname = NULL)	-- entweder den part hier oder die IS NULL checks auf die variablen in den SELECT statements weggeben, beides macht keinen sinn
			BEGIN
				PRINT 'Es wurde nur ein Parameter übergeben, die Suche wird sowohl in Vorname als auch in NACHNAHME durchgeführt...'
				SET @Vorname = @Nachname
			END
			ELSE 
			BEGIN
				PRINT 'Es wurde nur ein Parameter übergeben, die Suche wird sowohl in Vorname als auch in NACHNAHME durchgeführt...'
				SET @Nachname = @Vorname
			END
				
			IF (SELECT COUNT(*) FROM Angestellte WHERE (@Nachname IS NULL OR  Nachname LIKE '%' + @Nachname + '%') AND (@Vorname IS NULL OR  Vorname LIKE '%' + @Vorname + '%')) = 0
				THROW 50003, 'Es konnte keine Person mit gegebenen Vor-/Nachnamen gefunden werden' , 1
		
			SELECT * FROM Angestellte
			WHERE (@Nachname IS NULL OR  Nachname LIKE '%' + @Nachname + '%')
			AND (@Vorname IS NULL OR  Vorname LIKE '%' + @Vorname + '%');
			
			-- ROLLBACK
			COMMIT
			
		END TRY
		
		BEGIN CATCH
			
			SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
			ROLLBACK
			
		END CATCH
		
	END  
GO  

-- EXECUTE getAngestellte @Vorname = 'Corne' go;

-- stored procedure for viewing a Projekt

GO  

CREATE PROCEDURE uspGetProjekt
(@Name VARCHAR(MAX) = NULL)
    -- Add the parameters for the stored procedure here  
     
AS  
	BEGIN TRANSACTION
	
		BEGIN TRY
		
			IF (select COUNT(*) from Projekt where @Name = Name) = 0
				THROW 50004, 'Dieses Projekt existiert nicht' , 1
			
			SELECT * FROM Projekt
			WHERE @Name = Name;
			
			-- ROLLBACK
			COMMIT
			
		END TRY
		
		BEGIN CATCH
		
			SELECT ERROR_NUMBER() AS ErrorNumber, ERROR_MESSAGE() AS ErrorMessage;
			ROLLBACK
			
		END CATCH
		
	END  
GO  

-- Trigger: Update Anzahl Angestellte on INSERT (New employee)

DROP TRIGGER IF EXISTS trgUpdateAnzahlOnInsert
GO

CREATE TRIGGER trgUpdateAnzahlOnInsert
ON Angestellte AFTER INSERT
AS
	BEGIN
	
		IF (CURSOR_STATUS('global', 'csrUpdateAnzahlAngestellte') >= -1)	-- deallocates cursor if it exists
			DEALLOCATE csrUpdateAnzahlAngestellte;
			
		DECLARE csrUpdateAnzahlAngestellte CURSOR FAST_FORWARD FOR (SELECT FK_Abt_nr FROM INSERTED)
		DECLARE @abtNr INTEGER 

		OPEN csrUpdateAnzahlAngestellte 
		FETCH NEXT FROM csrUpdateAnzahlAngestellte INTO @abtNr
		
		IF @@FETCH_STATUS <> 0	-- rolls back transaction and throws error-message if inserted-table does not contain any rows
		BEGIN
			THROW 50004, 'trgUpdateAnzahlOnInsert_Error: Es konnten keine neuen Zeilen gefunden werden', 1
		END

		WHILE @@FETCH_STATUS = 0 
		BEGIN 

			UPDATE Abteilung 
			SET Anzahl_Angestellte += 1
			WHERE PK_Abt_Nr = @abtNr;
			
			FETCH NEXT FROM csrUpdateAnzahlAngestellte INTO @abtNr  
		END

		CLOSE csrUpdateAnzahlAngestellte
		DEALLOCATE csrUpdateAnzahlAngestellte
		
	END
GO


-- Trigger: Update Anzahl Angestellte on UPDATE (Switch department)

DROP TRIGGER IF EXISTS trgUpdateAnzahlOnEdit
GO

CREATE TRIGGER trgUpdateAnzahlOnEdit
ON Angestellte AFTER UPDATE
AS
	BEGIN
	
		IF (INSERTED.FK_Abt_nr <> DELETED.FK_Abt_nr)
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