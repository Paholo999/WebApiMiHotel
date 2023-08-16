using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMiHotel.Models;

namespace WebApiMiHotel.Services.UsuarioService
{
    //contrato Usuario
    public interface IUsuarioService
    {
        Task<List<Usuario>> ObtenerTodos();
        Task<Usuario?> ObtenerUno(int id);
        Task<List<Usuario>> Agregar(Usuario usuario);   
        Task<List<Usuario>?> Update(int id, Usuario usuario);
        Task<List<Usuario>?> Delete(int id);
    }
}