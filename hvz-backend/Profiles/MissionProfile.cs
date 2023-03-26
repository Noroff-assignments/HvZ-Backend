using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;
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

            CreateMap<Mission, MissionTitleDTO>().ForMember(dto => dto.Title, opt => opt.MapFrom(map => map.Title));
            CreateMap<Mission, MissionDescriptionDTO>().ForMember(dto => dto.Description, opt => opt.MapFrom(map => map.Description));
            CreateMap<Mission, MissionLatDTO>().ForMember(dto => dto.Latitude, opt => opt.MapFrom(map => map.Latitude));
            CreateMap<Mission, MissionLongDTO>().ForMember(dto => dto.Longitude, opt => opt.MapFrom(map => map.Longitude));
            CreateMap<Mission, MissionZombieDTO>().ForMember(dto => dto.ZombieVisible, opt => opt.MapFrom(map => map.ZombieVisible));
            CreateMap<Mission, MissionHumanDTO>().ForMember(dto => dto.HumanVisible, opt => opt.MapFrom(map => map.HumanVisible));
            CreateMap<Mission, MissionBeginDTO>().ForMember(dto => dto.BeginTime, opt => opt.MapFrom(map => map.BeginTime));
            CreateMap<Mission, MissionEndDTO>().ForMember(dto => dto.EndTime, opt => opt.MapFrom(map => map.EndTime));



        }
    }
}