using AutoMapper;
using hvz_backend.Models;
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
        }
    }
}
