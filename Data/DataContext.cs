global using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiHotel.Models;

namespace WebApiMiHotel.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DBMiHotel;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        //EntityFrameworkCore
        //se define la conexion a la base de datos DBMiHotel, el server es localhost
        //se define tambien las entidades para poder utilizar EntityFramework como ORM y sus llaves principales y relaciones
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Habitacion> Habitaciones {get; set;}
        public DbSet<Reservacion> Reservaciones {get; set;}
        
        //llaves principales relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario").HasKey(usuario => new {usuario.IdUsuario});
            modelBuilder.Entity<Habitacion>().ToTable("Habitacion").HasKey(habitacion => new {habitacion.IdHabitacion});
            modelBuilder.Entity<Reservacion>().ToTable("Reservacion").HasKey(reservacion => new {reservacion.IdReservacion});

            modelBuilder.Entity<Reservacion>()
                .HasOne( reservacion => reservacion.Usuario)
                .WithOne( usuario => usuario.Reservacion)
                .HasForeignKey<Reservacion>( reservacion => reservacion.IdUsuario);

            modelBuilder.Entity<Reservacion>()
                .HasOne( reservacion => reservacion.Habitacion)
                .WithOne( habitacion => habitacion.Reservacion)
                .HasForeignKey<Reservacion>( reservacion => reservacion.IdHabitacion);

        }



    }
}