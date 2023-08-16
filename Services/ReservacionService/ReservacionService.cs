using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiHotel.Data;
using WebApiMiHotel.Models;

namespace WebApiMiHotel.Services.ReservacionService
{
    public class ReservacionService : IReservacionService
    {
        private readonly DataContext _context;

        public ReservacionService(DataContext context)
        {
            _context = context;
        }

        //se debe implementar crud
        Task<List<Reservacion>?> IReservacionService.Actualizar(int id, Reservacion reservacion)
        {
            throw new NotImplementedException();
        }

        Task<List<Reservacion>> IReservacionService.Agregar(Reservacion reservacion)
        {
            throw new NotImplementedException();
        }

        Task<List<Usuario>?> IReservacionService.Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Reservacion>> IReservacionService.ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        Task<Reservacion?> IReservacionService.ObtenerUno(int id)
        {
            throw new NotImplementedException();
        }
    }
}