use master;

drop database if exists Unternehm ;

create database Unternehm;
go
use Unternehm;
go

create table Abteilung(
  PK_Abt_nr integer identity primary key not null ,
  Name varchar(64) not null ,
  Anzahl_Angestellte integer  ,
  Email varchar(128) not null ,
  Telefon varchar(64)not null

);

create table Niederlassung(
  PK_FirmaID integer identity primary key not null ,
  Ort varchar(64) not null ,
  Telefon varchar(64) not null ,
  Email varchar(64) not null

);

create table Projekt(
  PK_Proj_nr integer identity not null primary key ,
  Name varchar(128) not null ,
  Start_Date datetime2 not null ,
  End_Date datetime2 ,
  FK_Nder_nr integer references Niederlassung(PK_FirmaID)


);



create table Kunde(
  PK_KundID integer identity not null primary key ,
  Vorname varchar(64) not null ,
  Nachname varchar(64)not null ,
  Sex varchar(1) check (Sex in('F','M')),
  Adresse varchar(128) not null ,
  City varchar(64) not null ,
  Telefon varchar(64)not null ,
  Email varchar(128) not null

);

create table Angestellte(
  PK_AngID integer identity(1,1) primary key  ,
  Sex varchar(1) check (Sex in('F','M')),
  Vorname varchar(64) not null ,
  Nachname varchar(64) not null ,
  Email varchar(128) ,
  Gehalt integer not null ,
  FirmaID integer references Niederlassung(PK_FirmaID) ,
  Abt_nr integer references Abteilung(PK_Abt_nr)




);


create  table Bestellung(
  BessID integer identity primary key not null ,
  FK_Proj integer  not null references Projekt(PK_Proj_nr),
  FK_Kunde integer not null references Kunde(PK_KundID),
  Datum datetime2 not null ,
  Preis integer not null


);








create table Pro_Ang(
  FK_AngID integer references Angestellte(PK_AngID),
  FK_Proj_nr integer references Projekt(PK_Proj_nr)
);




