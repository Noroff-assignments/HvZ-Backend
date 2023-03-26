using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;
using hvz_backend.Models.DTOs.Map;

namespace hvz_backend.Profiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<MapCreateDTO, Map>();
            CreateMap<MapUpdateDTO, Map>();
            CreateMap<Map, MapReadDTO>()
                .ForMember(DTO => DTO.Missions, options =>
                options.MapFrom(mapDomain => mapDomain.Missions.Select(mission => $"api/v1/map/{mission.MapId}/mission/{mission.Id}").ToList()))
                .ForMember(DTO => DTO.Safezones, options =>
                options.MapFrom(mapDomain => mapDomain.Safezones.Select(safezone => $"api/v1/map/{safezone.MapId}/safezone/{safezone.Id}").ToList()))
                .ForMember(DTO => DTO.Supplies, options =>
                options.MapFrom(mapDomain => mapDomain.Supplies.Select(supply => $"api/v1/map/{supply.MapId}/supply/{supply.Id}").ToList()))
                ;

            CreateMap<Map, MapNameDTO>().ForMember(dto => dto.MapName, opt => opt.MapFrom(map => map.MapName));
            CreateMap<Map, MapDescriptionDTO>().ForMember(dto => dto.MapDescription, opt => opt.MapFrom(map => map.MapDescription));
            CreateMap<Map, MapLatDTO>().ForMember(dto => dto.Latitude, opt => opt.MapFrom(map => map.Latitude));
            CreateMap<Map, MapLongDTO>().ForMember(dto => dto.Longitude, opt => opt.MapFrom(map => map.Longitude));
            CreateMap<Map, MapRadiusDTO>().ForMember(dto => dto.Radius, opt => opt.MapFrom(map => map.Radius));



        }
    }
}
