using AutoMapper;
using hvz_backend.Models;
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
        }
    }
}
