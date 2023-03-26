using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Mission;
using hvz_backend.Models.DTOs.Safezone;

namespace hvz_backend.Profiles
{
    public class SafezoneProfile : Profile
    {
        public SafezoneProfile()
        {
            CreateMap<SafezoneCreateDTO, Safezone>();
            CreateMap<SafezoneUpdateDTO, Safezone>();
            CreateMap<Safezone, SafezoneReadDTO>();

            CreateMap<Safezone, SafezoneTitleDTO>().ForMember(dto => dto.Title, opt => opt.MapFrom(map => map.Title));
            CreateMap<Safezone, SafezoneDescriptionDTO>().ForMember(dto => dto.Description, opt => opt.MapFrom(map => map.Description));
            CreateMap<Safezone, SafezoneLatDTO>().ForMember(dto => dto.Latitude, opt => opt.MapFrom(map => map.Latitude));
            CreateMap<Safezone, SafezoneLonDTO>().ForMember(dto => dto.Longitude, opt => opt.MapFrom(map => map.Longitude));
            CreateMap<Safezone, SafezoneZombieDTO>().ForMember(dto => dto.ZombieVisible, opt => opt.MapFrom(map => map.ZombieVisible));
            CreateMap<Safezone, SafezoneHumanDTO>().ForMember(dto => dto.HumanVisible, opt => opt.MapFrom(map => map.HumanVisible));
            CreateMap<Safezone, SafezoneBeginDTO>().ForMember(dto => dto.BeginTime, opt => opt.MapFrom(map => map.BeginTime));
            CreateMap<Safezone, SafezoneEndDTO>().ForMember(dto => dto.EndTime, opt => opt.MapFrom(map => map.EndTime));
            CreateMap<Safezone, SafezoneRadiusDTO>().ForMember(dto => dto.Radius, opt => opt.MapFrom(map => map.Radius));

        }
    }
}
