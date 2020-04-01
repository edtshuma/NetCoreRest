using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetRestFul.Controllers
{
    [Route("/[controller]")]
    [ApiController]     
    public class RoomsController : ControllerBase
    {
        [HttpGet(Name =nameof(GetRooms))]
        [ProducesResponseType(200)]
        public IActionResult GetRooms(){

            throw new NotImplementedException();
         }
    }
}
