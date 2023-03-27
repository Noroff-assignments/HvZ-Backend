using AutoMapper;
using hvz_backend.Models;
using hvz_backend.Models.DTOs.Kill;
using hvz_backend.Models.DTOs.Squad;

namespace hvz_backend.Profiles
{
    public class SquadProfile : Profile
    {
        public SquadProfile()
        {
            CreateMap<SquadCreateDTO, Squad>();
            CreateMap<SquadUpdateDTO, Squad>();
            CreateMap<Squad, SquadReadDTO>()
                .ForMember(DTO => DTO.Players, options =>
                options.MapFrom(squadDomain => squadDomain.Players.Select(player => $"api/v1/game/{player.GameId}/squad/{player.SquadId}/player/{player.Id}").ToList()))
                ;

            CreateMap<Squad, SquadDescriptionDTO>().ForMember(dto => dto.Description, opt => opt.MapFrom(game => game.Description));
            CreateMap<Squad, SquadNameDTO>().ForMember(dto => dto.Name, opt => opt.MapFrom(game => game.Name));
            CreateMap<Squad, SquadTotalDeadDTO>().ForMember(dto => dto.TotalDead, opt => opt.MapFrom(game => game.TotalDead));
            CreateMap<Squad, SquadTotalPlayerDTO>().ForMember(dto => dto.TotalPlayer, opt => opt.MapFrom(game => game.TotalPlayer));

        }
    }
}