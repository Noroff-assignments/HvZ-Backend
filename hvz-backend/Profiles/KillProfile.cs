using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Kill;

namespace hvz_backend.Profiles
{
    public class KillProfile : Profile
    {
        public KillProfile() 
        { 
        CreateMap<KillCreateDTO, Kill>();
        CreateMap<KillUpdateDTO, Kill>();
        CreateMap<Kill, KillReadDTO>();
        }
    }
}
