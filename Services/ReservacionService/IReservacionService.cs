using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiHotel.Models;

namespace WebApiMiHotel.Services.ReservacionService
{
    //contrato Reservacion
    public interface IReservacionService
    {
        Task<List<Reservacion>> ObtenerTodos();
        Task<Reservacion?> ObtenerUno(int id);
        Task<List<Reservacion>> Agregar(Reservacion reservacion);   
        Task<List<Reservacion>?> Actualizar(int id, Reservacion reservacion);
        
        Task<List<Usuario>?> Eliminar(int id);
    }
}