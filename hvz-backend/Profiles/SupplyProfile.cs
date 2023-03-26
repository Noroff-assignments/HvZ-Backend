using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Mission;
using hvz_backend.Models.DTOs.Supply;

namespace hvz_backend.Profiles
{
    public class SupplyProfile : Profile
    {
        public SupplyProfile()
        {
            CreateMap<SupplyCreateDTO, Supply>();
            CreateMap<SupplyUpdateDTO, Supply>();
            CreateMap<Supply, SupplyReadDTO>();

            CreateMap<Supply, SupplyTitleDTO>().ForMember(dto => dto.Title, opt => opt.MapFrom(map => map.Title));
            CreateMap<Supply, SupplyDescriptionDTO>().ForMember(dto => dto.Description, opt => opt.MapFrom(map => map.Description));
            CreateMap<Supply, SupplyLatDTO>().ForMember(dto => dto.Latitude, opt => opt.MapFrom(map => map.Latitude));
            CreateMap<Supply, SupplyLongDTO>().ForMember(dto => dto.Longitude, opt => opt.MapFrom(map => map.Longitude));
            CreateMap<Supply, SupplyZombieDTO>().ForMember(dto => dto.ZombieVisible, opt => opt.MapFrom(map => map.ZombieVisible));
            CreateMap<Supply, SupplyHumanDTO>().ForMember(dto => dto.HumanVisible, opt => opt.MapFrom(map => map.HumanVisible));
            CreateMap<Supply, SupplyBeginDTO>().ForMember(dto => dto.BeginTime, opt => opt.MapFrom(map => map.BeginTime));
            CreateMap<Supply, SupplyEndDTO>().ForMember(dto => dto.EndTime, opt => opt.MapFrom(map => map.EndTime));
            CreateMap<Supply, SupplyDropDTO>().ForMember(dto => dto.Drop, opt => opt.MapFrom(map => map.Drop));
            CreateMap<Supply, SupplyAmountDTO>().ForMember(dto => dto.Amount, opt => opt.MapFrom(map => map.Amount));

        }
    }
}
