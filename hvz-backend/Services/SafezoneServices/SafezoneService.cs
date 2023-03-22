using hvz_backend.Exceptions;
using hvz_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Services.SafezoneServices
{
    public class SafezoneService : ISafezoneService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public SafezoneService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Create
        public async Task<Safezone> CreateSafezone(Safezone safezone)
        {
            if (safezone == null) throw new ArgumentNullException(nameof(safezone));
            _context.Safezones.Add(safezone);
            await _context.SaveChangesAsync();
            return safezone;
        }
        #endregion

        #region Read
        public async Task<IEnumerable<Safezone>> GetAllSafezonesInMap(int mapId)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezones = map.Safezones;
            if (safezones == null) throw new SafezoneNotFoundException();
            return safezones;
        }

        public async Task<Safezone> GetSafezoneByIdInMap(int mapId, int id)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new SafezoneNotFoundException(id);
            return safezone;
        }
        #endregion

        #region Update
        public async Task<Safezone> UpdateSafezone(Safezone safezone)
        {
            var foundSafezone = await _context.Safezones.AnyAsync(m => m.Id == safezone.Id);
            if (!foundSafezone) throw new SafezoneNotFoundException(safezone.Id);

            _context.Entry(safezone).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return safezone;
        }
        #endregion

        #region Delete
        public async Task DeleteSafezone(int id)
        {
            Safezone? safezone = await _context.Safezones.FindAsync(id);

            if (safezone == null) throw new SafezoneNotFoundException(id);
            _context.Safezones.Remove(safezone);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
