using hvz_backend.Models;
using hvz_backend.Models.Enums;

namespace hvz_backend.Services.SupplyServices
{
    public interface ISupplyService
    {
        Task<Supply> CreateSupply(Supply supply);
        Task<IEnumerable<Supply>> GetAllSuppliesInMap(int mapId);
        Task<Supply> GetSupplyByIdInMap(int mapId, int id);
        Task<Supply> UpdateSupply(Supply supply);
        Task DeleteSupply(int id);

        Task PatchTitleSupply(int mapId, int id, string title);
        Task PatchDescriptionSupply(int mapId, int id, string description);

        Task PatchLatSupply(int mapId, int id, double latitude);
        Task PatchLongSupply(int mapId, int id, double longitude);

        Task PatchZombieSupply(int mapId, int id, bool zombieVisible);
        Task PatchHumanSupply(int mapId, int id, bool humanVisible);

        Task PatchBeginSupply(int mapId, int id, DateTime beginTime);
        Task PatchEndSupply(int mapId, int id, DateTime endTime);

        Task PatchDropSupply(int mapId, int id, ItemType drop);
        Task PatchAmountSupply(int mapId, int id, int Amount);

    }
}
