using Microsoft.EntityFrameworkCore;
using hvz_backend.Models;
using hvz_backend.Exceptions;
using hvz_backend.Models.Enums;
using Microsoft.OpenApi.Extensions;

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
            if (game == null) throw new GameNotFoundException(id);
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


        public async Task PatchTitleGame(int id, string title)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) throw new GameNotFoundException(id);
            game.Title= title;
            await _context.SaveChangesAsync();
        }

        public async Task PatchAdminGame(int id, string adminId)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) throw new GameNotFoundException(id);
            game.AdminID = adminId;
            await _context.SaveChangesAsync();
        }
        public async Task PatchDescriptionGame(int id, string description)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) throw new GameNotFoundException(id);
            game.Description = description;
            await _context.SaveChangesAsync();
        }

        public async Task PatchBeginTimeGame(int id, DateTime begin)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) throw new GameNotFoundException(id);
            game.BeginTime = begin;
            await _context.SaveChangesAsync();
        }

        public async Task PatchEndTimeGame(int id, DateTime end)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) throw new GameNotFoundException(id);
            game.EndTime = end;
            await _context.SaveChangesAsync();
        }

        public async Task PatchStateGame(int id, StateGame state)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) throw new GameNotFoundException(id);
            game.Status = state;
            await _context.SaveChangesAsync();
        }

        public async Task PatchAmountGame(int id, int amountPlayer)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null) throw new GameNotFoundException(id);
            game.AmountPlayers = amountPlayer;
            await _context.SaveChangesAsync();
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
