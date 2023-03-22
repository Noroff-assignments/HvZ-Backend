using Microsoft.EntityFrameworkCore;
using hvz_backend.Models;
using hvz_backend.Exceptions;

namespace hvz_backend.Services.GameServices
{
    public class GameService : IGameService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public GameService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Create
        public async Task<Game> CreateGame(Game game)
        {
            if (game == null) throw new ArgumentNullException(nameof(game));
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
            return game;
        }
        #endregion

        #region Read
        public async Task<IEnumerable<Game>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> GetGameById(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) 
            {
                throw new GameNotFoundException(id);
            
            }
            return game;
        }
        #endregion

        #region Update
        public async Task<Game> UpdateGame(Game game)
        {
            var foundGame = await _context.Games.AnyAsync(m => m.Id == game.Id);
            if (!foundGame) throw new GameNotFoundException(game.Id);

            _context.Entry(game).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return game;
        }
        #endregion

        #region Delete
        public async Task DeleteGame(int id)
        {
            Game? game = await _context.Games.FindAsync(id);

            if (game == null) throw new GameNotFoundException(id);
            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
        }
        #endregion


    }
}
