
--tablice opisujące samochody
create table wypSamochod(
IdSam int identity(1,1) not null primary key,
IdMarka int not null,
IdModel int not null,
IdTablRej nvarchar(12) not null,
[Status] bit not null default(0),
[RokProd] int not null,
TypSilnika int not null,
Active bit default(1)
)

create table wypMarka(
IdMarka int identity(1,1) Primary key,
Nazwa nvarchar(50) not null
)
create table wypModel(
IdModel int identity(1,1) Primary key,
Nazwa nvarchar(50) not null,
IdMarka int
)
create table wypSilnik(
IdTypSilnik int primary key,
Nazwa nvarchar(10) not null
)

--tablice transakcji
--transakcja wypożyczenia(id samochodu, od kiedy do kiedy, stawka,klient)
--Klienci
--Stawki

