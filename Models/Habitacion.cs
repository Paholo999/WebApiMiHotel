using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMiHotel.Models
{
    public class Habitacion
    {
        public int IdHabitacion {get; set; }
	    public string Tipo {get; set;} = string.Empty;
	    public string Descripcion {get; set;} = string.Empty;
	    public double Precio {get; set; }
	    public string Foto {get; set;} = string.Empty;
	    public bool Reservado {get; set;}
        public virtual required Reservacion Reservacion { get; set; }
    }
}