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
            CreateMap<Game, GameAdminDTO>().ForMember(dto => dto.AdminID, opt => opt.MapFrom(game => game.AdminID));
            CreateMap<Game, GameDescriptionDTO>().ForMember(dto => dto.Description, opt => opt.MapFrom(game => game.Description));
            CreateMap<Game, GameBeginTimeDTO>().ForMember(dto => dto.BeginTime, opt => opt.MapFrom(game => game.BeginTime));
            CreateMap<Game, GameEndTimeDTO>().ForMember(dto => dto.EndTime, opt => opt.MapFrom(game => game.EndTime));
            CreateMap<Game, GameStateDTO>().ForMember(dto => dto.Status, opt => opt.MapFrom(game => game.Status));
            CreateMap<Game, GameTitleDTO>().ForMember(dto => dto.Title, opt => opt.MapFrom(game => game.Title));

        }
    }
}
