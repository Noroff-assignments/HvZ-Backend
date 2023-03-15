using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Game;

namespace hvz_backend.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile() 
        {
            CreateMap<GameCreateDTO, Game>();
            CreateMap<Game, GameReadDTO>()
                .ForMember(DTO => DTO.Players, options =>
                options.MapFrom(gameDomain => gameDomain.Players.Select(player => $"api/v1/player/{player.Id}").ToList()));
            CreateMap<GameUpdateDTO, Game>();
        }
    }
}
