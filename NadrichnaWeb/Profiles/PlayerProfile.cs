using AutoMapper;
using NadrichnaWeb.Db;
using NadrichnaWeb.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadrichnaWeb.Profiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, PlayerDto>()
                    .ForMember(p => p.BirthdayDay, opt => opt.MapFrom(player => player.Birthday.Day))
                    .ForMember(p => p.BirthdayMonth, opt => opt.MapFrom(player => player.Birthday.Month))
                    .ForMember(p => p.BirthdayYear, opt => opt.MapFrom(player => player.Birthday.Year));
            CreateMap<PlayerDto, Player>();
        }
    }
}
