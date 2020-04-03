using ASPNetRestFul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetRestFul.Services
{
    public interface IRoomService
    {

        Task<Room> GetRoomAsync(Guid id);
    }
}
