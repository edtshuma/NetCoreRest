using ASPNetRestFul.Models;
using System;
using System.Threading.Tasks;

namespace ASPNetRestFul.Services
{
    public interface IRoomService
    {

        Task<Room> GetRoomAsync(Guid id);
    }
}
