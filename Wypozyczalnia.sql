
--tablice opisujące samochody
create table wypSamochod(
[IdSam] int identity(1,1) not null primary key,
[IdMarka] int not null,
[IdModel] int not null,
[TablRej] nvarchar(12) not null,
[Status] bit not null default(0),
[RokProd] int not null,
[IdPaliwa] int not null,
[Kolor]nvarchar(30) null,
[Pojemnosc] decimal(6,2) default(1.6),
[Active] bit default(1)
)

create table wypMarka(
[IdMarka] int identity(1,1) Primary key,
[Nazwa] nvarchar(50) not null
)

create table wypModel(
[IdModel] int identity(1,1) Primary key,
[Nazwa] nvarchar(50) not null,
[IdMarka] int
)
create table wypPaliwo(
[IdTypSilnik] int primary key,
[Nazwa] nvarchar(10) not null
)

create table wypKlient(
[IdKlient] int Identity(1,1) PRIMARY KEY,
[Nazwa] nvarchar(200) not null,
[NIP] nvarchar(14) not null,
[Ulica] nvarchar(200) not null,
[Miasto] nvarchar(200) not null,
[NrDomu] nvarchar(10) not null,
[NrMieszkania] nvarchar(8) not null,
[KodPocz] nvarchar(6) not null,
[Tel] nvarchar(50) not null default(' '),
[OsobaKont] nvarchar(300) not null default(' ')
)

create table wypWypozycz(
[IdWypo] int identity(1,1)PRIMARY KEY,
[IdSamo] int not null,
[IdKlient] int not null,
[DStart] smalldatetime not null,
[DStop] smalldatetime not null,
[Stawka] decimal(8,2) not null,
[Suma] decimal(8,2) not null
 )
 
 create table wypNaprawa(
[IdNapr] int identity(1,1) PRIMARY key,
[IdSamo] int not null,
[DStart] smalldatetime not null,
[DStop] smalldatetime not null,
[Kwota] decimal(8,2) not null
 )
 
-Create table wypWypoDni(
[IdTran][int] Identity(1,1),
[IdSamo][int] not null,
[IdKlient][int] not null,
[DataWyp][Date] not null,
[Stawka][decimal] not null
)
 
 --Klucze 
 
 --Marka-Model
If Exists (select * from dbo.sysobjects where id= object_id(N'FK_wypMarka_wypModel'))
BEGIN
	PRINT '!!!POWIĄZANIE ''FK_wypMarka_wypModel'' juz istnieje'
	END
ELSE
	BEGIN
		ALTER TABLE [dbo].[wypModel]  WITH CHECK ADD  CONSTRAINT [FK_wypMarka_wypModel] FOREIGN KEY([IdMarka])
		REFERENCES [dbo].[wypMarka] ([IdMarka])
		ALTER TABLE [dbo].[wypModel] CHECK CONSTRAINT [FK_wypMarka_wypModel]
	END
	GO
--Klucze wypPaliwo->wypSamochod


If Exists (select * from dbo.sysobjects where id= object_id(N'FK_wypPaliwo_wypSamochod'))
BEGIN
	PRINT '!!!POWIĄZANIE ''FK_wypPaliwo_wypSamochod'' juz istnieje'
	END
ELSE
	BEGIN
		ALTER TABLE [dbo].[wypSamochod]  WITH CHECK ADD  CONSTRAINT [FK_wypPaliwo_wypSamochod] FOREIGN KEY([IdPaliwa])
		REFERENCES [dbo].[wypPaliwo] ([IdTypSilnik])
		ALTER TABLE [dbo].[wypSamochod] CHECK CONSTRAINT [FK_wypPaliwo_wypSamochod]
	END
	GO

--Klucze wypModel->wypSamochod

	
If Exists (select * from dbo.sysobjects where id= object_id(N'FK_wypModel_wypSamochod'))
BEGIN
	PRINT '!!!POWIĄZANIE ''FK_wypModel_wypSamochod'' juz istnieje'
	END
ELSE
	BEGIN
		ALTER TABLE [dbo].[wypSamochod]  WITH CHECK ADD  CONSTRAINT [FK_wypModel_wypSamochod] FOREIGN KEY([IdModel])
		REFERENCES [dbo].[wypModel] ([IdModel])
		ALTER TABLE [dbo].[wypSamochod] CHECK CONSTRAINT [FK_wypModel_wypSamochod]
	END
	GO

--Klucze wypMarka->wypSamochod

	
If Exists (select * from dbo.sysobjects where id= object_id(N'FK_wypMarka_wypSamochod'))
BEGIN
	PRINT '!!!POWIĄZANIE ''FK_wypMarka_wypSamochod'' juz istnieje'
	END
ELSE
	BEGIN
		ALTER TABLE [dbo].[wypSamochod]  WITH CHECK ADD  CONSTRAINT [FK_wypMarka_wypSamochod] FOREIGN KEY([IdMarka])
		REFERENCES [dbo].[wypMarka] ([IdMarka])
		ALTER TABLE [dbo].[wypSamochod] CHECK CONSTRAINT [FK_wypMarka_wypSamochod]
	END
	GO
	
--Klucze CD.
--IdSamo->wypWypo
If Exists (select * from dbo.sysobjects where id= object_id(N'FK_wypSamo_wypWypozycz'))
BEGIN
	PRINT '!!!POWIĄZANIE ''FK_wypSamo_wypWypozycz'' juz istnieje'
	END
ELSE
	BEGIN
		ALTER TABLE [dbo].[wypWypozycz]  WITH CHECK ADD  CONSTRAINT [FK_wypSamo_wypWypozycz] FOREIGN KEY([IdSamo])
		REFERENCES [dbo].[wypSamochod] ([IdSam])
		ALTER TABLE [dbo].[wypWypozycz] CHECK CONSTRAINT [FK_wypSamo_wypWypozycz]
	END
	GO

--IdKlient->wypWypo
If Exists (select * from dbo.sysobjects where id= object_id(N'FK_wypKlient_wypWypozycz'))
BEGIN
	PRINT '!!!POWIĄZANIE ''FK_wypKlient_wypWypozycz'' juz istnieje'
	END
ELSE
	BEGIN
		ALTER TABLE [dbo].[wypWypozycz]  WITH CHECK ADD  CONSTRAINT [FK_wypKlient_wypWypozycz] FOREIGN KEY([IdKlient])
		REFERENCES [dbo].[wypKlient] ([IdKlient])
		ALTER TABLE [dbo].[wypWypozycz] CHECK CONSTRAINT [FK_wypKlient_wypWypozycz]
	END
	GO


--IdSamo->wypNaprawa
If Exists (select * from dbo.sysobjects where id= object_id(N'FK_wypSamo_wypNaprawa'))
BEGIN
	PRINT '!!!POWIĄZANIE ''FK_wypSamo_wypNaprawa'' juz istnieje'
	END
ELSE
	BEGIN
		ALTER TABLE [dbo].[wypNaprawa]  WITH CHECK ADD  CONSTRAINT [FK_wypSamo_wypNaprawa] FOREIGN KEY([IdSamo])
		REFERENCES [dbo].[wypSamochod] ([IdSam])
		ALTER TABLE [dbo].[wypNaprawa] CHECK CONSTRAINT [FK_wypSamo_wypNaprawa]
	END
	GO





 
--tablice transakcji
--transakcja wypożyczenia(id samochodu, od kiedy do kiedy, stawka,klient)
--Klienci
--Stawki

