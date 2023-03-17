using hvz_backend.Models;

namespace hvz_backend.Services.SupplyServices
{
    public class SupplyService : ISupplyService
    {
        public Task<Supply> CreateSupply(Supply supply)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supply>> GetAllSupplys()
        {
            throw new NotImplementedException();
        }

        public Task<Supply> GetSupplyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
