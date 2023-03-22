using hvz_backend.Models;

namespace hvz_backend.Services.PlayerServices
{
    public interface IPlayerService
    {
        Task<Player> CreatePlayer(Player supply);
        Task<IEnumerable<Player>> GetAllPlayersInMap(int mapId);
        Task<Player> GetPlayerByIdInMap(int mapId, int id);
        Task<Player> UpdatePlayer(Player player);
        Task DeletePlayer(int id);
    }
}
