using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMiHotel.Models
{
    public class Reservacion
    {
        public int IdReservacion {get; set; }
        public int IdUsuario {get; set; }
        public int IdHabitacion {get; set; }
	    public string FechadeRegistro {get; set; } = string.Empty;
	    public string FechadeSalida {get; set; } = string.Empty;
        public virtual required Usuario Usuario { get; set; }
        public virtual required Habitacion Habitacion { get; set; }
    }
}