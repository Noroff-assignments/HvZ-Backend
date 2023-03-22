using hvz_backend.Exceptions;
using hvz_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Services.SquadServices
{
    public class SquadService : ISquadService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public SquadService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Create
        public async Task<Squad> CreateSquad(Squad squad)
        {
            if (squad == null) throw new ArgumentNullException(nameof(squad));
            _context.Squads.Add(squad);
            await _context.SaveChangesAsync();
            return squad;
        }
        #endregion

        #region Read
        public async Task<IEnumerable<Squad>> GetAllSquadsInMap(int gameId)
        {
            var game = await _context.Games
                .Include(m => m.Squads)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var squads = game.Squads;
            if (squads == null) throw new SquadNotFoundException();
            return squads;
        }

        public async Task<Squad> GetSquadByIdInMap(int gameId, int id)
        {
            var game = await _context.Games
                .Include(m => m.Squads)
                .Where(k => k.Id == gameId)
                .FirstOrDefaultAsync();
            if (game == null) throw new GameNotFoundException(gameId);
            var squad = game.Squads.FirstOrDefault(k => k.Id == id);
            if (squad == null) throw new SquadNotFoundException(id);
            return squad;
        }
        #endregion


        #region Update
        public async Task<Squad> UpdateSquad(Squad squad)
        {
            var foundSquad = await _context.Squads.AnyAsync(m => m.Id == squad.Id);
            if (!foundSquad) throw new SquadNotFoundException(squad.Id);

            _context.Entry(squad).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return squad;
        }
        #endregion

        #region Delete
        public async Task DeleteSquad(int id)
        {
            Squad? squad = await _context.Squads.FindAsync(id);

            if (squad == null) throw new SquadNotFoundException(id);
            _context.Squads.Remove(squad);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
