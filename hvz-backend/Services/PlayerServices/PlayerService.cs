using hvz_backend.Exceptions;
using hvz_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Services.PlayerServices
{
    public class PlayerService : IPlayerService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public PlayerService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Create
        public async Task<Player> CreatePlayer(Player player)
        {
            if (player == null) throw new ArgumentNullException(nameof(player));
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }
        #endregion

        #region Read
        public async Task<IEnumerable<Player>> GetAllPlayersInMap(int gameId)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var players = game.Players;
            if (players == null) throw new PlayerNotFoundException();
            return players;
        }

        public async Task<Player> GetPlayerByIdInMap(int gameId, int id)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var player = game.Players.FirstOrDefault(k => k.Id == id);
            if (player == null) throw new PlayerNotFoundException(id);
            return player;
        }
        #endregion


        #region Update
        public async Task<Player> UpdatePlayer(Player player)
        {
            var foundPlayer = await _context.Players.AnyAsync(m => m.Id == player.Id);
            if (!foundPlayer) throw new PlayerNotFoundException(player.Id);

            _context.Entry(player).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return player;
        }
        #endregion

        #region Delete
        public async Task DeletePlayer(int id)
        {
            Player? player = await _context.Players.FindAsync(id);

            if (player == null) throw new PlayerNotFoundException(id);
            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
