using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMiHotel.Models
{
    public class Usuario
    {
        public int IdUsuario {get; set; }
	    public string Nombres {get; set;} = string.Empty;
	    public string Apellidos {get; set;} = string.Empty;
	    public string Email {get; set;} = string.Empty;
	    public string Celular {get; set;} = string.Empty;
        public virtual required Reservacion Reservacion { get; set; }
    }
}