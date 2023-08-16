using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiMiHotel.Services.ReservacionService;

namespace WebApiMiHotel.Controllers
{
    [ApiController]
    [Route("v1/ApiMiHotel/[controller]")]
    public class RerservacionController : ControllerBase
    {
        IReservacionService _reservacionService;

        public RerservacionController(IReservacionService reservacionService)
        {
            _reservacionService = reservacionService;
        }

        
    }
}