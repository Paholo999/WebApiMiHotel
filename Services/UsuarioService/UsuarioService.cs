using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiHotel.Models;

namespace WebApiMiHotel.Services.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        Task<List<Usuario>> IUsuarioService.Agregar(Usuario usuario)
        {
            throw new NotImplementedException();
        }
        //se debe implementar crud
        Task<List<Usuario>?> IUsuarioService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Usuario>> IUsuarioService.ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        Task<Usuario?> IUsuarioService.ObtenerUno(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Usuario>?> IUsuarioService.Update(int id, Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}