Según lo requerido se creo una aplicación web, el backend se desarrolló en Asp.Net Core Web Api y el 
interfaz de usuario en Angular FrontEndMiHotel, en la API se realizó la conexión a una base de datos llamada DBMiHotel en SQL Server
utilizando Entity Framework como ORM

En la API se creo una interfaz que posee un CRUD de cada entidad, pero no se ha implementado en un 
controlador, en el controlador de habitación se creó dos endpoint llamados ObtenerTodos donde se 
obtiene toda la lista de habitaciones requeridas y Reservar que actualiza el campo reservado de la entidad 
Habitación como false para definir que está reservado

dotnet new webapi -n WebApiMiHotel

dotnet add package Microsoft.EntityFrameworkCore  

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef migrations add InitialCreate

Base de datos sql server
