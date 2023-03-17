using hvz_backend.Models;

namespace hvz_backend.Services.PlayerServices
{
    public interface IPlayerService
    {
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Map> GetPlayerById(int id);
        Task<Map> CreatePlayer(Player player);
    }
}
