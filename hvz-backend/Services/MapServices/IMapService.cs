using hvz_backend.Models;

namespace hvz_backend.Services.MapServices
{
    public interface IMapService
    {
        Task<IEnumerable<Map>> GetAllMaps();
        Task<Map> GetMapById(int id);
        Task<Map> CreateMap(Map map);
    }
}
