using AutoMapper;
using hvz_backend.Models;
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
        }
    }
}
