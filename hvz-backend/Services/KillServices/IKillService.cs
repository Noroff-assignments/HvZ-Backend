using hvz_backend.Models;

namespace hvz_backend.Services.KillServices
{
    public interface IKillService
    {
        Task<IEnumerable<Kill>> GetAllKills();
        Task<Kill> GetKillById(int id);
        Task<Kill> CreateKill(Kill kill);
    }
}
