
--------------------------------------------------------------------------------
-- Database finished / Subject to changes --

CREATE TABLE Oficina (
	id int primary key not null identity(1,1),
	ubicacion varchar(25) not null unique,
	telefono varchar(25) not null unique
)

CREATE TABLE Propietario (
	id int primary key not null identity(1,1),
	nombre varchar(50) not null,
	telefono varchar(25) not null,
	correo varchar(50),
	cedula varchar(15),
)

CREATE TABLE Inmueble (
    id int primary key not null identity(1,1),
	id_oficina int,
	id_propietario int,
	precio_venta float,
	precio_alquiler float,
	direccion varchar(75),
	metros_cuadrados float,
    ruta_foto varchar(255),
	
	foreign key (id_oficina) references Oficina(id),
	foreign key (id_propietario) references Propietario(id)
)

CREATE TABLE Cliente (
	id int primary key not null identity(1,1),
	nombre varchar(50) not null,
	telefono varchar(25) not null,
	correo varchar(50),
	cedula varchar(15)
)

CREATE TABLE Visitas (
	id int primary key not null identity(1,1),
	id_inmueble int,
	id_cliente int,
	comment varchar(1000) not null,
	fecha date,
	hora time,
	
	foreign key (id_inmueble) references Inmueble(id),
	foreign key (id_cliente) references Cliente(id)
)

CREATE TABLE Locales (
	id int primary key not null identity(1,1),
	zona varchar(25) not null,
	es_diafano bit,
	altillo_altura float,
	vado bit,
	agua bit,
	luz bit,
	esta_acondicionado bit,
	numero_puertas int,
	id_inmueble  int,

	foreign key (id_inmueble) references Inmueble(id)
)

CREATE TABLE Vivienda (
	id int primary key not null identity(1,1),
	habitaciones int,
	baños int,
	salon bit,
	armarios int,
	m2_terraza float,
	garaje bit,
	gas bit,
	calefaccion bit,
	id_inmueble int,

	foreign key (id_inmueble) references Inmueble(id)
)

CREATE TABLE Villa (
  	id int primary key not null identity(1,1),
  	parcela float,
  	urbanizacion varchar(25) not null,
	id_vivienda int, 

  	foreign key (id_vivienda) references Vivienda(id)	
)

CREATE TABLE Piso (
  	id int primary key not null identity(1,1),
  	zona varchar(25) not null,
  	nuevo bit,
  	ocasion bit,
	id_vivienda int, 

  	foreign key (id_vivienda) references Vivienda(id)
)

CREATE TABLE Casa(
  	id int primary key not null identity (1,1),
  	zona varchar(25) not null,
	id_vivienda int, 

  	foreign key (id_vivienda) references Vivienda(id)
)



