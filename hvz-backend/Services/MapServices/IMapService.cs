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

        Task PatchNameMap(int id, string name);
        Task PatchDescriptionMap (int id, string description);
        Task PatchLatitudeMap (int id, double latitude);
        Task PatchLongitudeMap (int id, double longitude);
    }
}
