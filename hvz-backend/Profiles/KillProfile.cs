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

            CreateMap<Kill, KillKillerDTO>().ForMember(dto => dto.KillerId, opt => opt.MapFrom(game => game.KillerId));
            CreateMap<Kill, KillLatDTO>().ForMember(dto => dto.Latitude, opt => opt.MapFrom(game => game.Latitude));
            CreateMap<Kill, KillLongDTO>().ForMember(dto => dto.Longitude, opt => opt.MapFrom(game => game.Longitude));
            CreateMap<Kill, KillStoryDTO>().ForMember(dto => dto.DeadStory, opt => opt.MapFrom(game => game.DeadStory));
            CreateMap<Kill, KillTimeDeadDTO>().ForMember(dto => dto.TimeDead, opt => opt.MapFrom(game => game.TimeDead));
            CreateMap<Kill, KillVictimDTO>().ForMember(dto => dto.VictimId, opt => opt.MapFrom(game => game.VictimId));
        }
    }
}
