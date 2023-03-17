using hvz_backend.Models;

namespace hvz_backend.Services.PlayerServices
{
    public class PlayerService : IPlayerService
    {
        public Task<Map> CreatePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Player>> GetAllPlayers()
        {
            throw new NotImplementedException();
        }

        public Task<Map> GetPlayerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
