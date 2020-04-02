using ASPNetRestFul.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetRestFul
{
    public static class SeedData
    {
        public static async Task InitialiseAsync(IServiceProvider services)
        {
            await AddTestData(
                services.GetRequiredService<HotelApiDbContext>());
        }

        public static async Task AddTestData(HotelApiDbContext hotelApiDbContext)
        {
            //if (hotelApiDbContext.Any())
            //{
            //    return;
            //}

            hotelApiDbContext.Rooms.Add(new RoomEntity
            {
                Id = Guid.Parse("301df04d-8679-4b1b-ab92-0a586ae53d08"),
               Name = "OxforD Suite",
               Rate=10119
            });

            hotelApiDbContext.Rooms.Add(new RoomEntity
            {
                Id = Guid.Parse("ee2b83be-91db-4de5-8122-35a9e9195976"),
                Name = "Dracoll Suite",
                Rate = 23959
            });

            await hotelApiDbContext.SaveChangesAsync();
        }
    }
}
