using hvz_backend.Models;

namespace hvz_backend.Services.GameServices
{
    public interface IGameService
    {
        Task<IEnumerable<Game>> GetAllGames();
    }
}
