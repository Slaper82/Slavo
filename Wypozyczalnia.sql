
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
[Tel] nvarchar(15) not null default(' '),
[OsobaKont] nvarchar(100) not null default(' ')
)

--tablice transakcji
--transakcja wypożyczenia(id samochodu, od kiedy do kiedy, stawka,klient)
--Klienci
--Stawki

