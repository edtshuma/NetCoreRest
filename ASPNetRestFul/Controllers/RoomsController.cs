using ASPNetRestFul.Models;
using ASPNetRestFul.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
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
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {

            _roomService = roomService;
        }

        [HttpGet(Name =nameof(GetRooms))]
        [ProducesResponseType(200)]
        public IActionResult GetRooms(){

            throw new NotImplementedException();
         }

        //Get /rooms/{roomId}
        [HttpGet("{roomId}", Name=nameof(GetRoomById))]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public async Task <ActionResult<Room>> GetRoomById(Guid roomId)
        {
            var room = await _roomService.GetRoomAsync(roomId);
            if (room == null) return NotFound();

            return room;

        }
    }
}
