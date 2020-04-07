using System;
using System.Threading.Tasks;
using ASPNetRestFul.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASPNetRestFul.Services
{
    public class DefaultRoomService : IRoomService
    {

        private readonly HotelApiDbContext _context;
        private readonly IMapper _mapper;

        public DefaultRoomService(HotelApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        async Task<Room> IRoomService.GetRoomAsync(Guid id)
        {
            var entity = await _context.Rooms
                .SingleOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {

                return null;
            }

            return _mapper.Map<Room>(entity);
            //return new Room
            //{
            //    Href = null,
            //    Name = entity.Name,
            //    Rate = entity.Rate / 100.0m

            //};


        }
    }
}
