using ASPNetRestFul.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetRestFul.Infrastructure
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            CreateMap<RoomEntity, Room>()
                .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => src.Rate / 100m));
            //TODO Url.Link
        }
    }
}
