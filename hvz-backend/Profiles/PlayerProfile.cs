using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;
using hvz_backend.Models.DTOs.Player;

namespace hvz_backend.Profiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<PlayerCreateDTO, Player>();
            CreateMap<PlayerUpdateDTO, Player>();
            CreateMap<Player, PlayerReadDTO>();

            CreateMap<Player, PlayerBiteDTO>().ForMember(dto => dto.BiteCode, opt => opt.MapFrom(game => game.BiteCode));
            CreateMap<Player, PlayerLatDTO>().ForMember(dto => dto.Latitude, opt => opt.MapFrom(game => game.Latitude));
            CreateMap<Player, PlayerLongDTO>().ForMember(dto => dto.Longitude, opt => opt.MapFrom(game => game.Longitude));
            CreateMap<Player, PlayerPatientDTO>().ForMember(dto => dto.IsPatientZero, opt => opt.MapFrom(game => game.IsPatientZero));
            CreateMap<Player, PlayerSquadDTO>().ForMember(dto => dto.SquadId, opt => opt.MapFrom(game => game.SquadId));
            CreateMap<Player, PlayerUserDTO>().ForMember(dto => dto.UserID, opt => opt.MapFrom(game => game.UserID));
            CreateMap<Player, PlayerZombieDTO>().ForMember(dto => dto.IsZombie, opt => opt.MapFrom(game => game.IsZombie));

        }
    }
}
