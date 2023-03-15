using Microsoft.EntityFrameworkCore;
using hvz_backend.Models;

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

        public async Task<IEnumerable<Game>> GetAllGames()
        {
            return await _context.Games.ToListAsync();
        }


    }
}
