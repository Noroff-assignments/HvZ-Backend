using hvz_backend.Models;

namespace hvz_backend.Services.KillServices
{
    public interface IKillService
    {
        Task<Kill> CreateKill(Kill supply);
        Task<IEnumerable<Kill>> GetAllKillsInGame(int gameId);
        Task<Kill> GetKillByIdInGame(int gameId, int id);
        Task<Kill> UpdateKill(Kill kill);
        Task DeleteKill(int id);

        Task PatchDeadStoryKill(int gameId, int id, string story);
        Task PatchKillerKill(int gameId, int id, int killerId);
        Task PatchVictimKill(int gameId, int id, int victimId);

    }
}
