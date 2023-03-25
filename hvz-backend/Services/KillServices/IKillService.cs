using hvz_backend.Models;

namespace hvz_backend.Services.KillServices
{
    public interface IKillService
    {
        Task<Kill> CreateKill(Kill supply);
        Task<IEnumerable<Kill>> GetAllKillsInMap(int mapId);
        Task<Kill> GetKillByIdInMap(int mapId, int id);
        Task<Kill> UpdateKill(Kill kill);
        Task DeleteKill(int id);

        Task PatchDeadStoryKill(int mapId, int id, string story);
        Task PatchKillerKill(int mapId, int id, int killerId);
        Task PatchVictimKill(int mapId, int id, int victimId);

    }
}
