using hvz_backend.Exceptions;
using hvz_backend.Models;
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
