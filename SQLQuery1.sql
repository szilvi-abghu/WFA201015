-- create database turautvonalak;
-- use turautvonalak;

create table turazo(
id int primary key identity,
vezeteknev varchar(255),
keresztnev varchar(255),
varos varchar(255),
telefonszam varchar(255));

create table utvonal(
id int primary key identity,
turazoId int foreign key references turazo(id),
honnan varchar(255),
hova varchar(255),
km int);

insert into turazo (vezeteknev, keresztnev, varos, telefonszam) values
('Kiss','Manyi','Velence','06701234567'),
('Nagy','Imre','Budapest','06703216547'),
('Tompa','Mihály','Budapest','06207854563');

insert into utvonal (turazoId, honnan, hova, km) values
(2,'Budapest','Monor',38),
(3,'Budapest','Esztergom',54);

