create table wypLogowanie(
[IdUser] int identity(1,1),
[Nazwa] nvarchar(50) not null unique,
[Pass] nvarchar(20) not null,
[IdUpra] int not null

)

create table wypUprawnienia(
[IdUpra] int not null,
[Nazwa] nvarchar(20)
)

insert into wypUprawnienia values (1,'Administrator')
insert into wypUprawnienia values (2,'Kierownik')
insert into wypUprawnienia values (3,'Pracownik')


insert into wypLogowanie values('sl','sl',1)
insert into wypLogowanie values('pr','pr',2)