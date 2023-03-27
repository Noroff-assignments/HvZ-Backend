using hvz_backend.Models;

namespace hvz_backend.Services.SquadServices
{
    public interface ISquadService
    {
        Task<Squad> CreateSquad(Squad squad);
        Task<IEnumerable<Squad>> GetAllSquadsInGame(int gameId);
        Task<Squad> GetSquadByIdInGame(int gameId, int id);
        Task<Squad> UpdateSquad(Squad squad);
        Task DeleteSquad(int id);

        Task PatchNameSquad(int gameId, int id, string name);
        Task PatchDescriptionSquad(int gameId, int id, string description);

        Task PatchTotalPlayerSquad(int gameId, int id, int totalplayer);

        Task PatchTotalDeadSquad(int gameId, int id, int totaldead);


        //Task<Squad> AddSquadMember(int squadId,Player player);
        //Task<Squad> GetSquadCheckIn(int squadId);
        //Task<Squad> CreateSquadCheckIn()
    }
}
