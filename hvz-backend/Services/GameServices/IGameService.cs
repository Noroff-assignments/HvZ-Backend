using hvz_backend.Models;
using hvz_backend.Models.Enums;

namespace hvz_backend.Services.GameServices
{
    public interface IGameService
    {
        Task<IEnumerable<Game>> GetAllGames();
        Task<Game> GetGameById(int id);
        Task<Game> CreateGame(Game game);
        Task<Game> UpdateGame(Game game);
        Task DeleteGame(int id);
        Task PatchTitleGame(int id, string title);
        Task PatchDescriptionGame(int id, string Description);
        Task PatchAdminGame(int id, string adminId);
        Task PatchBeginTimeGame(int id, DateTime begin);
        Task PatchEndTimeGame(int id, DateTime end);
        Task PatchStateGame(int id, StateGame state);

        Task PatchAmountGame(int id, int amount);

    }
}
