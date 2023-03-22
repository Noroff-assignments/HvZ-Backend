using hvz_backend.Models;

namespace hvz_backend.Services.SupplyServices
{
    public interface ISupplyService
    {
        Task<Supply> CreateSupply(Supply supply);
        Task<IEnumerable<Supply>> GetAllSuppliesInMap(int mapId);
        Task<Supply> GetSupplyByIdInMap(int mapId, int id);
        Task<Supply> UpdateSupply(Supply supply);
        Task DeleteSupply(int id);
    }
}
