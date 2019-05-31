-- Se crea la base de datos
create database cinepapu;
-- Se utiliza la base de datos
use cinepapu;
-- Creamos una tabla de usuario con atributos: Nombre, Email, Tipo, Contraseña
create table Usuarios(
Nombre varchar (45) not null,
Email varchar (45) not null primary key,
Tipo enum('admin','user') not null,
Contrasena varchar(45) not null
);

-- Creamos una tabla de peliculas con las descripciones generales de quien las hizo, de que tratan, año, su poster, etc
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

-- Creamos una tabla para las interacciones con varios atributos: El ID, Email, Nombre, Comentario, Liked, Index, etc
CREATE TABLE Interacciones
(	
	idInteraccion int Not Null primary key auto_increment,
    Email Varchar(150) NOT NULL,
    Nombre Varchar(150) NOT NULL,
    Comentario   longtext,
    Liked		bool,    
    INDEX (Email),
    FOREIGN KEY (Email) REFERENCES usuarios(Email),
    FOREIGN KEY (Nombre) REFERENCES Peliculas(Nombre)
);

-- Insertamos 2 usuarios
-- El primero es una administrador y el segundo un usuario
insert into Usuarios (Nombre,Email,Tipo,Contrasena) values('Rok','Rika_js@outlook.com','admin','Rok');
insert into Usuarios (Nombre,Email,Tipo,Contrasena) values('Rika','icky_0307@hotmail.com','user','Rok');

-- Insertamos 2 peliculas 
INSERT INTO Peliculas(Nombre, Descripccion, Autor, Ano, Genero, UrlVideo, UrlImagen) 
VALUES ('Ready Player One','Buena peli','Steven Spielberg','2018',5,'https://mega.nz/embed#!3d5nCA5R!osi7iZD2abALC7agwVRh0BgddpReMJkDl92rOq69KZM','ReadyPlayerOne.png');
INSERT INTO Peliculas(Nombre, Descripccion, Autor, Ano, Genero, UrlVideo, UrlImagen) 
VALUES ('Iron Man','Buena','S','2018',1,'https://www.youtube.com/watch?v=8hYlB38asDY','ironman.jpg');

/* Se seleccionan todas las peliculas y todos los usuarios */
select * from peliculas;
select * from usuarios;
/*drop database cinepapu;
drop table usuarios;
drop table peliculas;*/
