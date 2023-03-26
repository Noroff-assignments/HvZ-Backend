using hvz_backend.Exceptions;
using hvz_backend.Models;
using hvz_backend.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Services.SupplyServices
{
    public class SupplyService : ISupplyService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public SupplyService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Create
        public async Task<Supply> CreateSupply(Supply supply)
        {
            if (supply == null) throw new ArgumentNullException(nameof(supply));
            _context.Supplies.Add(supply);
            await _context.SaveChangesAsync();
            return supply;
        }
        #endregion

        #region Read
        public async Task<IEnumerable<Supply>> GetAllSuppliesInMap(int mapId)
        {            
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supplies = map.Supplies;
            if (supplies == null) throw new SupplyNotFoundException();
            return supplies;
        }

        public async Task<Supply> GetSupplyByIdInMap(int mapId, int id)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new SupplyNotFoundException(id);
            return supply;
        }
        #endregion


        #region Update
        public async Task<Supply> UpdateSupply(Supply supply)
        {
            var foundSupply = await _context.Supplies.AnyAsync(m => m.Id == supply.Id);
            if (!foundSupply) throw new SupplyNotFoundException(supply.Id);

            _context.Entry(supply).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return supply;
        }

        public async Task PatchTitleSupply(int mapId, int id, string title)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.Title = title;
            await _context.SaveChangesAsync();
        }

        public async Task PatchDescriptionSupply(int mapId, int id, string description)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.Description = description;
            await _context.SaveChangesAsync();
        }

        public async Task PatchLatSupply(int mapId, int id, double lat)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.Latitude = lat;
            await _context.SaveChangesAsync();
        }

        public async Task PatchLongSupply(int mapId, int id, double lon)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.Longitude = lon;
            await _context.SaveChangesAsync();
        }

        public async Task PatchZombieSupply(int mapId, int id, bool zombieVisible)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.ZombieVisible = zombieVisible;
            await _context.SaveChangesAsync();
        }

        public async Task PatchHumanSupply(int mapId, int id, bool humanVisible)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.HumanVisible = humanVisible;
            await _context.SaveChangesAsync();
        }

        public async Task PatchBeginSupply(int mapId, int id, DateTime beginTime)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.BeginTime = beginTime;
            await _context.SaveChangesAsync();
        }

        public async Task PatchEndSupply(int mapId, int id, DateTime endTime)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.EndTime = endTime;
            await _context.SaveChangesAsync();
        }

        public async Task PatchDropSupply(int mapId, int id, ItemType drop)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.Drop = drop;
            await _context.SaveChangesAsync();
        }

        public async Task PatchAmountSupply(int mapId, int id, int amount)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.Amount = amount;
            await _context.SaveChangesAsync();
        }

        public async Task PatchRadiusSupply(int mapId, int id, int radius)
        {
            var map = await _context.Maps
                .Include(m => m.Supplies)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var supply = map.Supplies.FirstOrDefault(k => k.Id == id);
            if (supply == null) throw new KillNotFoundException(id);
            supply.Radius = radius;
            await _context.SaveChangesAsync();
        }

        #endregion

        #region Delete
        public async Task DeleteSupply(int id)
        {
            Supply? supply = await _context.Supplies.FindAsync(id);

            if (supply == null) throw new SupplyNotFoundException(id);
            _context.Supplies.Remove(supply);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
