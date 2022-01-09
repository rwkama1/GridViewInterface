--COMANDOS DE CREACION DE TABLA DDL
--Se cambia a la base de datos Master
use Master;
go
--Determina si esta la base de datos Libreria
if exists(Select * FROM SysDataBases WHERE name='Libreria')
BEGIN
	--BORRA LA BASE DE DATOS Libreria (OJO CON ESTO)
	DROP DATABASE Libreria
END

--Crea la base de datos Libreria en el lugar especificado
--Notar que la base de datos puede tener nombre diferente al archivo
--Basta con el comando CREATE DATABASE Libreria
CREATE DATABASE Libreria
ON(
	NAME=Libreria,
	FILENAME='C:\Libreria.mdf'
)
GO
-----------------------------------------------------------
USE Libreria;
GO

--Se crean tablas con Primary key y Foreign Key

--El comando PRIMARY KEY indica que ese campo es clave primaria
CREATE TABLE Productos(
            IdProducto int Identity (1,1)not null primary key,
            FotoChica varchar (100) ,
            FotoGrande varchar (100) ,
            Nombre varchar (100) unique,
            Precio float,
			EntregaInmediata bit
) 
GO

INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)
VALUES('~/Imagenes/pcu025c.jpg','~/Imagenes/pcu025g.jpg','Wireless',11.11,0);
INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES('~/Imagenes/pcu069c.jpg','~/Imagenes/pcu069g.jpg','ASP.nET',22.22,1);
INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES('~/Imagenes/pcu072c.jpg','~/Imagenes/pcu072g.jpg','JAVA',33.33,0);
INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES('~/Imagenes/pcu073c.jpg','~/Imagenes/pcu073g.jpg','Técnicas de Programacion',44.44,1);
INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES('~/Imagenes/pcu076c.jpg','~/Imagenes/pcu076g.jpg','C#',55.55,0);
INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES('~/Imagenes/pcu077c.jpg','~/Imagenes/pcu077g.jpg','Moviles con .Net',66.66,1);
INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES('~/Imagenes/pcu085c.jpg','~/Imagenes/pcu085g.jpg','Sql Server 2005',77.77,0);
INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES('~/Imagenes/pcu091c.jpg','~/Imagenes/pcu091g.jpg','Xml',77.77,1);
GO

--Selecciona IdProducto ,Foto ,Nombre ,Precio de todos los productos 
CREATE      PROCEDURE ListarProductos AS
BEGIN 
	SELECT IdProducto, FotoChica,FotoGrande, Nombre, Precio,EntregaInmediata 
	FROM Productos;
END
GO

CREATE      PROCEDURE BuscarProducto @id int AS
BEGIN 
	SELECT IdProducto, FotoChica, FotoGrande, Nombre, Precio,EntregaInmediata
	FROM Productos
	WHERE @id=IdProducto;
END
GO

CREATE      PROCEDURE AgregarProducto @FotoChica varchar(100), @FotoGrande varchar(100), @Nombre varchar(100), @Precio float AS
BEGIN 
	if exists (SELECT * FROM Productos WHERE @Nombre=nombre)
		return -1
	INSERT INTO  Productos(FotoChica,FotoGrande ,Nombre ,Precio, EntregaInmediata)VALUES(@FotoChica,@FotoGrande ,@Nombre ,@Precio, 'true');
		return @@identity;
END
GO
