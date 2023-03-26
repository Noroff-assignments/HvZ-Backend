using hvz_backend.Models;

namespace hvz_backend.Services.SafezoneServices
{
    public interface ISafezoneService
    {
        Task<Safezone> CreateSafezone(Safezone safezone);
        Task<IEnumerable<Safezone>> GetAllSafezonesInMap(int mapId);
        Task<Safezone> GetSafezoneByIdInMap(int mapId, int id);
        Task<Safezone> UpdateSafezone(Safezone safezone);
        Task DeleteSafezone(int id);

        Task PatchTitleSafezone(int mapId, int id, string title);
        Task PatchDescriptionSafezone(int mapId, int id, string description);

        Task PatchLatSafezone(int mapId, int id, double latitude);
        Task PatchLongSafezone(int mapId, int id, double longitude);

        Task PatchZombieSafezone(int mapId, int id, bool zombieVisible);
        Task PatchHumanSafezone(int mapId, int id, bool humanVisible);

        Task PatchBeginSafezone(int mapId, int id, DateTime beginTime);
        Task PatchEndSafezone(int mapId, int id, DateTime endTime);
        Task PatchRadiusSafezone(int mapId, int id, int radius);

    }
}
