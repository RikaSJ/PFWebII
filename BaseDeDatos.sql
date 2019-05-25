create database cinepapu;
use cinepapu;
create table Usuarios(
Nombre varchar (45) not null,
Email varchar (45) not null primary key,
Tipo enum('admin','user') not null,
Contrasena varchar(45) not null
);
create table Peliculas(
Nombre varchar (45) not null,
Descripccion longtext not null,
Autor varchar (45) not null,
Ano varchar(4) not null,
Genero enum('Ciencia ficcion','Terror',' Comedia',' Thriller',' Accion',' Aventura ','Animada',' Fantasia',' Drama',' Romanticas') not null,
UrlVideo varchar(300) not null,
UrlImagen varchar(300) not null,
primary key(Nombre)
);
insert into Usuarios (Nombre,Email,Tipo,Contrasena) values('Rok','Rika_js@outlook.com','admin','Rok');
insert into Usuarios (Nombre,Email,Tipo,Contrasena) values('Rika','icky_0307@hotmail.com','user','Rok');
INSERT INTO Peliculas(Nombre, Descripccion, Autor, Ano, Genero, UrlVideo, UrlImagen) 
VALUES ('Ready Player One','Buena peli','Steven Spielberg','2018',5,'https://mega.nz/embed#!3d5nCA5R!osi7iZD2abALC7agwVRh0BgddpReMJkDl92rOq69KZM','ReadyPlayerOne.png');
INSERT INTO Peliculas(Nombre, Descripccion, Autor, Ano, Genero, UrlVideo, UrlImagen) 
VALUES ('Iron Man','Buena','S','2018',1,'https://www.youtube.com/watch?v=8hYlB38asDY','ironman.jpg');


select * from peliculas;
select * from usuarios;
/*drop database cinepapu;
drop table usuarios;
drop table peliculas;*/