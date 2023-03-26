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

        public async Task PatchTitleSafezone(int mapId, int id, string title)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.Title = title;
            await _context.SaveChangesAsync();
        }

        public async Task PatchDescriptionSafezone(int mapId, int id, string description)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.Description = description;
            await _context.SaveChangesAsync();
        }

        public async Task PatchLatSafezone(int mapId, int id, double lat)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.Latitude = lat;
            await _context.SaveChangesAsync();
        }

        public async Task PatchLongSafezone(int mapId, int id, double lon)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.Longitude = lon;
            await _context.SaveChangesAsync();
        }

        public async Task PatchZombieSafezone(int mapId, int id, bool zombieVisible)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.ZombieVisible = zombieVisible;
            await _context.SaveChangesAsync();
        }

        public async Task PatchHumanSafezone(int mapId, int id, bool humanVisible)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.HumanVisible = humanVisible;
            await _context.SaveChangesAsync();
        }

        public async Task PatchBeginSafezone(int mapId, int id, DateTime beginTime)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.BeginTime = beginTime;
            await _context.SaveChangesAsync();
        }

        public async Task PatchEndSafezone(int mapId, int id, DateTime endTime)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.EndTime = endTime;
            await _context.SaveChangesAsync();
        }

        public async Task PatchRadiusSafezone(int mapId, int id, int radius)
        {
            var map = await _context.Maps
                .Include(m => m.Safezones)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var safezone = map.Safezones.FirstOrDefault(k => k.Id == id);
            if (safezone == null) throw new KillNotFoundException(id);
            safezone.Radius = radius;
            await _context.SaveChangesAsync();
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
