using hvz_backend.Exceptions;
using hvz_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Services.KillServices
{
    public class KillService : IKillService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public KillService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Create
        public async Task<Kill> CreateKill(Kill kill)
        {
            if (kill == null) throw new ArgumentNullException(nameof(kill));
            _context.Kills.Add(kill);
            await _context.SaveChangesAsync();
            return kill;
        }
        #endregion

        #region Read
        public async Task<IEnumerable<Kill>> GetAllKillsInGame(int gameId)
        {
            var game = await _context.Games
                .Include(m => m.Kills)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var kills = game.Kills;
            if (kills == null) throw new KillNotFoundException();
            return kills;
        }

        public async Task<Kill> GetKillByIdInGame(int gameId, int id)
        {
            var game = await _context.Games
                .Include(m => m.Kills)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var kill = game.Kills.FirstOrDefault(k => k.Id == id);
            if (kill == null) throw new KillNotFoundException(id);
            return kill;
        }

        #endregion


        #region Update
        public async Task<Kill> UpdateKill(Kill kill)
        {
            var foundKill = await _context.Kills.AnyAsync(m => m.Id == kill.Id);
            if (!foundKill) throw new KillNotFoundException(kill.Id);

            _context.Entry(kill).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return kill;
        }

        public async Task PatchDeadStoryKill(int gameId, int id, string story)
        {
            var game = await _context.Games
                .Include(m => m.Kills)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var kill = game.Kills.FirstOrDefault(k => k.Id == id);
            if (kill == null) throw new KillNotFoundException(id);
            kill.DeadStory = story;
            await _context.SaveChangesAsync();
        }

        public async Task PatchKillerKill(int gameId, int id, int killerId)
        {
            var game = await _context.Games
                .Include(m => m.Kills)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var kill = game.Kills.FirstOrDefault(k => k.Id == id);
            if (kill == null) throw new KillNotFoundException(id);
            kill.KillerId = killerId;
            await _context.SaveChangesAsync();
        }

        public async Task PatchVictimKill(int gameId, int id, int victimId)
        {
            var game = await _context.Games
                .Include(m => m.Kills)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var kill = game.Kills.FirstOrDefault(k => k.Id == id);
            if (kill == null) throw new KillNotFoundException(id);
            kill.VictimId = victimId;
            await _context.SaveChangesAsync();
        }

        #endregion

        #region Delete
        public async Task DeleteKill(int id)
        {
            Kill? kill = await _context.Kills.FindAsync(id);

            if (kill == null) throw new KillNotFoundException(id);
            _context.Kills.Remove(kill);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
