CREATE DATABASE mydb;
GO
USE mydb
GO
CREATE TABLE [usuario] (
id int,
nombre varchar(25),
apellido varchar(25), 
email varchar(50),
passwrd varchar(30),
CONSTRAINT usuario_pk PRIMARY KEY (id)
)
GO
INSERT INTO [usuario] values (1,'Pedro','Perez','pperez@virtualmind.com','password123')
INSERT INTO [usuario] values (2,'Pablo','Rodriguez','prodriguez@virtualmind.com','password123')
INSERT INTO [usuario] values (3,'Felipe','Gutierrez','pgutuerrez@virtualmind.com','password123')
INSERT INTO [usuario] values (4,'Juan','Garcia','jgarcia@virtualmind.com','password123')
INSERT INTO [usuario] values (5,'Mario','Lopez','mlopez@virtualmind.com','password123')
INSERT INTO [usuario] values (6,'Cristian','Sanchez','csanchez@virtualmind.com','password123')
INSERT INTO [usuario] values (7,'Rolando','Hernandez','rhernandez@virtualmind.com','password123')
