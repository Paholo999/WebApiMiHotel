using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiMiHotel.Models;
using WebApiMiHotel.Services.HabitacionService;

namespace WebApiMiHotel.Controllers
{
    [ApiController]
    [Route("v1/ApiMiHotel/[controller]")]
    public class HabitacionController : ControllerBase
    {
        IHabitacionService _habitacionService;

        public HabitacionController(IHabitacionService habitacionService)
        {
            _habitacionService = habitacionService;
        }

        //mostrar lista de habitaciones
        //peticion get
        [HttpGet]
        public async Task<ActionResult<List<Habitacion>>> ObtenerTodos()
        {
            return await _habitacionService.ObtenerTodos();
        }

        //reservar habitacion cambiando el campo Reservado a False, revisar HabitacionService
        //peticion put
        [HttpPut("ReservarHabitacion/{id}")]
        public async Task<ActionResult<List<Habitacion>>> Reservar(int id, bool request)
        {
            var result = await _habitacionService.Reservar(id,request);
            if(result is null)
                return NotFound("Habitacion no encontrada");

            return Ok(result);
        }

    }
}