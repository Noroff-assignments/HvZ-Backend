using hvz_backend.Models;

namespace hvz_backend.Services.MapServices
{
    public interface IMapService
    {
        Task<Map> CreateMap(Map map);
        Task<IEnumerable<Map>> GetAllMaps();
        Task<Map> GetMapById(int id);
        Task<Map> UpdateMap(Map map);
        Task DeleteMap(int id);
    }
}
