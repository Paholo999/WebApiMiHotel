

create database DBMiHotel;
go

insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Suite','2 camas dobles, comedor y cocina',981.00,'/assets/img/suite.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Suite','comedor y cocina',800.00,'/assets/img/suite.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Suite','jacuzzi, comedor y cocina',1100.00,'/assets/img/suite.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Simple','comedor y cocina',490.00,'/assets/img/simple.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Simple','Sin comedor y cocina',200.00,'/assets/img/simple.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Suite','comedor y cocina',490.00,'/assets/img/simple.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Suite','Sin comedor y cocina',200.00,'/assets/img/simple.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Suite','comedor y cocina',490.00,'/assets/img/simple.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Dobles','Sin comedor y cocina, con baño',550.00,'/assets/img/dobles.jpg',1);
insert into Habitacion (Tipo,Descripcion,Precio,Foto,Reservado) values ('Dobles','baño, comedor y cocina',790.00,'/assets/img/dobles.jpg',1);


use DBMiHotel;
go




create table Usuario(
	IdUsuario int primary key identity,
	Nombres varchar(100),
	Apellidos varchar(100),
	Email varchar(100),
	Celular varchar(100),
	FechadeRegistro datetime default getdate()
)
go

create table Habitacion(
	IdHabitacion int primary key identity,
	Tipo varchar(100),
	Descripcion varchar(100),
	Precio float,
	Foto varchar(50),
	Reservado bit default 1,
)
go



create table Reservacion(
	IdReservacion int primary key identity,
	IdHabitacion int references Habitacion(IdHabitacion),
	IdUsuario int references Usuario(IdUsuario),
	FechadeRegistro varchar(100),
	FechadeSalida varchar(100)
)
go