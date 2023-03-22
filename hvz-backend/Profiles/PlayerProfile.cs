using AutoMapper;
using hvz_backend.Models;
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
        }
    }
}
