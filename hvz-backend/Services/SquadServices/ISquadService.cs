using hvz_backend.Models;

namespace hvz_backend.Services.SquadServices
{
    public interface ISquadService
    {
        Task<Squad> CreateSquad(Squad squad);
        Task<IEnumerable<Squad>> GetAllSquadsInMap(int gameId);
        Task<Squad> GetSquadByIdInMap(int gameId, int id);
        Task<Squad> UpdateSquad(Squad squad);
        Task DeleteSquad(int id);
        //Task<Squad> AddSquadMember(int squadId,Player player);
        //Task<Squad> GetSquadCheckIn(int squadId);
        //Task<Squad> CreateSquadCheckIn()
    }
}
