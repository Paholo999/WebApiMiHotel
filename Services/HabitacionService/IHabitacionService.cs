using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiHotel.Models;

namespace WebApiMiHotel.Services.HabitacionService
{
    //contrato Habitacion
    public interface IHabitacionService
    {
        Task<List<Habitacion>> ObtenerTodos();
        Task<Habitacion?> ObtenerUno(int id);
        Task<List<Habitacion>> Agregar(Habitacion habitacion);   
        Task<List<Habitacion>?> Actualizar(int id, Habitacion habitacion);
        Task<List<Habitacion>?> Reservar(int id, bool request);
        Task<List<Habitacion>?> Eliminar(int id);
    }
}