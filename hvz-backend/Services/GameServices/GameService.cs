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

        /// <summary>
        /// The service of getting all the games in the db.
        /// </summary>
        /// <returns>List of all games.</returns>
        public async Task<IEnumerable<Game>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }

        /// <summary>
        /// The service of getting a game based on a id.
        /// </summary>
        /// <param name="id">The unique id of a game.</param>
        /// <returns>The game of the unique id.</returns>
        /// <exception cref="GameNotFoundException">When the unique id is not in the db.</exception>
        public async Task<Game> GetGameById(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) 
            {
                throw new GameNotFoundException(id);
            
            }
            return game;
        }

        /// <summary>
        /// The service for creating a new game for the db.
        /// </summary>
        /// <param name="game">An game with parameter </param>
        /// <returns>Given game and post on db.</returns>
        /// <exception cref="ArgumentNullException">When given gane is null.</exception>
        public async Task<Game> CreateGame(Game game)
        {
            if (game == null) throw new ArgumentNullException(nameof(game));
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
            return game;
        }
    }
}
