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
    }
}
