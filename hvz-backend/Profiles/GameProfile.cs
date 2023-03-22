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
            CreateMap<GameUpdateDTO, Game>();
            CreateMap<Game, GameReadDTO>()
                .ForMember(DTO => DTO.Players, options =>
                options.MapFrom(gameDomain => gameDomain.Players.Select(player => $"api/v1/game/{gameDomain.Id}/player/{player.Id}").ToList()))
                .ForMember(DTO => DTO.Squads, options =>
                options.MapFrom(gameDomain => gameDomain.Squads.Select(squad => $"api/v1/game/{gameDomain.Id}/squad/{squad.Id}").ToList()))
                .ForMember(DTO => DTO.Kills, options =>
                options.MapFrom(gameDomain => gameDomain.Kills.Select(kill => $"api/v1/game/{gameDomain.Id}/kill/{kill.Id}").ToList()))
                ;
        }
    }
}
