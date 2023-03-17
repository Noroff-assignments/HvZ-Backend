using hvz_backend.Models;

namespace hvz_backend.Services.SafezoneServices
{
    public interface ISafezoneService
    {
        Task<IEnumerable<Safezone>> GetAllSafezones();
        Task<Safezone> GetSafezoneById(int id);
        Task<Safezone> CreateMap(Safezone safezone);
    }
}
