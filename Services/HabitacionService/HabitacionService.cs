using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiMiHotel.Data;
using WebApiMiHotel.Models;

namespace WebApiMiHotel.Services.HabitacionService
{
    public class HabitacionService : IHabitacionService
    {
        //definir DataContext
        //recibir dependencias de DataContext en el constructor de HabitacionService
        private readonly DataContext _context;

        public HabitacionService(DataContext context)
        {
            _context = context;
        }

        //listar datos
        public async Task<List<Habitacion>> ObtenerTodos()
        {
            var habitaciones = await _context.Habitaciones.ToListAsync();
            return habitaciones;
        }

        //realizar reservacion de habitacion
        public async Task<List<Habitacion>?> Reservar(int id, bool request)
        {
            var habitacion = await _context.Habitaciones.FindAsync(id);
            if(habitacion is null)
                return null;
            
            habitacion.Reservado = request;

            await _context.SaveChangesAsync();

            return await _context.Habitaciones.ToListAsync();

        }

        //se debe implementar crud
        Task<List<Habitacion>?> IHabitacionService.Actualizar(int id, Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        Task<List<Habitacion>> IHabitacionService.Agregar(Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        Task<List<Habitacion>?> IHabitacionService.Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        

        Task<Habitacion?> IHabitacionService.ObtenerUno(int id)
        {
            throw new NotImplementedException();
        }
    }
}