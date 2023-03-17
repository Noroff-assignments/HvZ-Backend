using hvz_backend.Models;

namespace hvz_backend.Services.SupplyServices
{
    public interface ISupplyService
    {
        Task<IEnumerable<Supply>> GetAllSupplys();
        Task<Supply> GetSupplyById(int id);
        Task<Supply> CreateSupply(Supply supply);
    }
}
