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
        public async Task<IEnumerable<Player>> GetAllPlayersInGame(int gameId)
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

        public async Task<IEnumerable<Player>> GetAllZombiesInGame(int gameId)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var players = game.Players.Where(z => z.IsZombie==true);
            if (players == null) throw new PlayerNotFoundException();
            return players;
        }

        public async Task<IEnumerable<Player>> GetAllHumansInGame(int gameId)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var players = game.Players.Where(h => h.IsZombie==false);
            if (players == null) throw new PlayerNotFoundException();
            return players;
        }

        public async Task<IEnumerable<string>> GetAllBiteCodeInGame(int gameId)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();

            if (game == null) throw new GameNotFoundException(gameId);

            var players = game.Players;
            if (!players.Any()) throw new PlayerNotFoundException();
            return players.Select(p => p.BiteCode);
        }

        public async Task<Player> GetPlayerByIdInGame(int gameId, int id)
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

        public async Task<Player> GetPlayerByUserIdInGame(int gameId, string userId)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var player = game.Players.FirstOrDefault(k => k.UserID == userId);
            if (player == null) throw new PlayerNotFoundException(player.Id);
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
       /* Task PatchLatPlayer(int gameId, int id, double lat);
        Task PatchlongPlayer(int gameId, int id, double lon);
        Task PatchSquadPlayer(int gameId, int id, int squadId);
        Task PatchisZombiePlayer(int gameId, int id, bool zombie);*/
        public async Task PatchLatPlayer(int gameId, int id, double lat)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var player = game.Players.FirstOrDefault(k => k.Id == id);
            if (player == null) throw new KillNotFoundException(id);
            player.Latitude = lat;
            await _context.SaveChangesAsync();
        }

        public async Task PatchlongPlayer(int gameId, int id, double lon)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var player = game.Players.FirstOrDefault(k => k.Id == id);
            if (player == null) throw new KillNotFoundException(id);
            player.Longitude = lon;
            await _context.SaveChangesAsync();
        }

        public async Task PatchSquadPlayer(int gameId, int id, int squadId)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var player = game.Players.FirstOrDefault(k => k.Id == id);
            if (player == null) throw new KillNotFoundException(id);
            player.SquadId = squadId;
            await _context.SaveChangesAsync();
        }

        public async Task PatchIsZombiePlayer(int gameId, int id, bool zombie)
        {
            var game = await _context.Games
                .Include(m => m.Players)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var player = game.Players.FirstOrDefault(k => k.Id == id);
            if (player == null) throw new KillNotFoundException(id);
            player.IsZombie = zombie;
            await _context.SaveChangesAsync();
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
