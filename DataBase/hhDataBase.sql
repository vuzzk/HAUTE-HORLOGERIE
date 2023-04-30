create database hh
use hh

create table Proizvodi(
proizvod_id int primary key identity(1,1),
ime nvarchar(100) not null,
sifra varchar(12) not null,
cena float,
kolicina int not null,
proizvodjac nvarchar(100) not null,
opis_id int,
kategorija_id int,
)

create table Opisi(
opis_id int primary key identity(1,1),
tekst nvarchar(500),
slika1 nvarchar(150),
slika2 nvarchar(150),
slika3 nvarchar(150),
slika4 nvarchar(150)
)

create table Kategorije(
kategorija_id int primary key identity(1,1),
ime nvarchar(100) not null,
opis nvarchar(500),
slika  nvarchar(150)
)

create table Korisnici(
korisnik_id int primary key identity(1,1),
ime nvarchar(100) not null,
prezime nvarchar(100) not null,
username nvarchar(30) not null unique,
lozinka nvarchar(255) not null,
email nvarchar(255) not null unique,
drzava nvarchar(100) not null,
grad nvarchar(255) not null,
postanski_br int not null,
adresa nvarchar(255) not null,
uloga_korisnika_id int not null,
)

create table UlogeKorisnika(
uloga_korisnika_id int primary key identity(1,1),
naziv varchar(100) not null unique
)

create table Porudzbine(
porudzbina_id int primary key identity(1,1),
korisnik_id int not null,
ukupan_iznos int not null,
datum_vreme date default getdate() not null,
porudzbina_uspesna varchar(2)
)

create table StavkePorudzbina(
stavka_porudzbine_id int primary key identity(1,1),
porudzbina_id int not null,
proizvod_id int not null,
kolicina int
)

ALTER table Proizvodi
add constraint FK_opis_id
FOREIGN KEY (opis_id)
REFERENCES Opisi(opis_id);

ALTER table Proizvodi
add constraint FK_kategorija_id
FOREIGN KEY (kategorija_id)
REFERENCES Kategorije(kategorija_id);

ALTER table Korisnici
add constraint FK_uloga_korisnika_id
FOREIGN KEY (uloga_korisnika_id)
REFERENCES UlogeKorisnika(uloga_korisnika_id);

ALTER table Porudzbine
add constraint FK_korisnik_id
FOREIGN KEY (korisnik_id)
REFERENCES Korisnici(korisnik_id);

ALTER table StavkePorudzbina
add constraint FK_proizvod_id
FOREIGN KEY (proizvod_id)
REFERENCES Proizvodi(proizvod_id);

ALTER table StavkePorudzbina
add constraint FK_porudzbina_id
FOREIGN KEY (porudzbina_id)
REFERENCES Porudzbine(porudzbina_id);

