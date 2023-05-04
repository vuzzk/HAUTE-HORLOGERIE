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

--POGLEDI---------------------------------------------

create view PregledProizvoda as
select Proizvodi.ime as 'NAME', sifra as 'SKU', cena as 'PRICE', kolicina as 'QUANTITY', proizvodjac as 'MANUFACTURER', tekst as 'DESCRIPTION',Kategorije.ime as 'CATEGORY' from Proizvodi
join Opisi on Proizvodi.opis_id = Opisi.opis_id
join Kategorije on Proizvodi.kategorija_id = Kategorije.kategorija_id
select * from PregledProizvoda

create view OstaliKorisnici as
select CONCAT(ime, ' ', prezime) as 'NAME',username as 'USERNAME', email as 'E-MAIL', drzava as 'COUNTRY', grad as 'CITY', postanski_br as 'ZIP CODE', adresa as 'ADRESS', naziv as 'ROLE' from Korisnici
join UlogeKorisnika on UlogeKorisnika.uloga_korisnika_id = Korisnici.uloga_korisnika_id 
where Korisnici.uloga_korisnika_id in (2,3)
select * from OstaliKorisnici



--INSERTI---------------------------------------------
Insert into Kategorije values
('Diver','Diver watches designed to withstand deepths of sea.',NULL),
('Dress','Dress watches ideal for big celebrations in your life.',NULL),
('GMT','GMT watches for people who are always in move.',NULL),
('Chronograph','A chronograph watch is a traditional timepiece fitted with an extra complication to act as a stopwatch.',NULL);

Insert into Opisi values
('Submariner Date in Oystersteel with a Cerachrom bezel insert in black ceramic and a black dial with large luminescent hour markers.', NULL,NULL,NULL,NULL),
('With traditional hour, minute and seconds hands, a triangle-tipped 24-hour hand, and a bidirectional rotatable bezel with a 24-hour graduated Cerachrom insert, the GMT-Master II can display the time in two time zones simultaneously: either the local time and the reference time, or the local time and that of an alternative time zone. The date, at 3 o’clock on the dial, is synchronized with the local time.', NULL,NULL,NULL,NULL),
('This 50th anniversary timepiece pays tribute to the “Silver Snoopy Award” that OMEGA received from NASA astronauts in 1970, in recognition of the brand’s contributions to space exploration, including the Apollo 13 mission. The 42 mm case in stainless steel is presented on a blue nylon fabric strap, which features the trajectory of the Apollo 13 mission on the embossed lining. ', NULL,NULL,NULL,NULL),
('Featuring the Lange outsize date and a precise moon-phase display, the SAXONIA MOON PHASE combines two classic complications. The symmetric arrangement of the date display at 12 o’clock and the moon-phase display in the top section of the subsidiary seconds dial at 6 o’clock emphasises the elegant design of this timepiece. The intense deep-blue colour of the solid-gold lunar disc is the result of a patented coating process.', NULL,NULL,NULL,NULL);

Insert into Proizvodi values
('Submariner Date Black 41mm','126610LN',15500,5,'Rolex',1,1),
('FMT Master II "Pepsi" 40mm','126710BLRO',25000,5,'Rolex',2,3),
('Speedmaster Silver Snoopy Award 42mm','310.32.42.50',15000,1,'Omega',4,5),
('Saxonia Moon Phase Rose Gold 40mm','384.032',15000,3,'A. Lange & Söhne',5,2);