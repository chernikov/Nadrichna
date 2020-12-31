using AutoMapper;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadrichnaWeb.Profiles
{
    public class HouseProfile : Profile
    {
        public HouseProfile()
        {
            CreateMap<House, HouseDto>();
            CreateMap<HouseDto, House>();
        }
    }
}
