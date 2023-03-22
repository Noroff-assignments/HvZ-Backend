using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Mission;

namespace hvz_backend.Profiles
{
    public class MissionProfile : Profile
    {
        public MissionProfile()
        {
            CreateMap<MissionCreateDTO, Mission>();
            CreateMap<MissionUpdateDTO, Mission>();
            CreateMap<Mission, MissionReadDTO>();
        }
    }
}