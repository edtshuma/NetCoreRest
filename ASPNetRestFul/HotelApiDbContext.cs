using ASPNetRestFul.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetRestFul
{
    public class HotelApiDbContext : DbContext
    {
        public HotelApiDbContext(DbContextOptions options)
            : base(options) { }

        internal bool Any()
        {
            throw new NotImplementedException();
        }

        public DbSet<RoomEntity> Rooms { get; set; }
    }
}
