using Microsoft.EntityFrameworkCore;
using hvz_backend.Models;
using hvz_backend.Exceptions;

namespace hvz_backend.Services.MapServices
{
    public class MapService : IMapService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public MapService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Create
        /// <summary>
        /// The service for creating a new map for the db.
        /// </summary>
        /// <param name="map">An map with parameter </param>
        /// <returns>Given map and post on db.</returns>
        /// <exception cref="ArgumentNullException">When given gane is null.</exception>
        public async Task<Map> CreateMap(Map map)
        {
            if (map == null) throw new ArgumentNullException(nameof(map));
            await _context.Maps.AddAsync(map);
            await _context.SaveChangesAsync();
            return map;
        }
        #endregion

        #region Read
        /// <summary>
        /// The service of getting all the maps in the db.
        /// </summary>
        /// <returns>List of all maps.</returns>
        public async Task<IEnumerable<Map>> GetAllMaps()
        {
            return await _context.Maps.ToListAsync();
        }

        /// <summary>
        /// The service of getting a map based on a id.
        /// </summary>
        /// <param name="id">The unique id of a map.</param>
        /// <returns>The map of the unique id.</returns>
        /// <exception cref="MapNotFoundException">When the unique id is not in the db.</exception>
        public async Task<Map> GetMapById(int id)
        {
            var map = await _context.Maps.FindAsync(id);
            if (map == null)
            {
                throw new MapNotFoundException();

            }
            return map;
        }
        #endregion

        #region Update
        /// <summary>
        /// Service for to update a map´.
        /// </summary>
        /// <param name="map">Map object.</param>
        /// <returns>The given map.</returns>
        /// <exception cref="MapNotFoundException">When the map do not exist. </exception>
        public async Task<Map> UpdateMap(Map map)
        {
            var foundMap = await _context.Maps.AnyAsync(m => m.Id == map.Id);
            if (!foundMap) throw new MapNotFoundException(map.Id);

            _context.Entry(map).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return map;
        }

        public async Task PatchNameMap(int id, string name)
        {
            var map = await _context.Maps.FindAsync(id);
            if (map == null) throw new GameNotFoundException(id);
            map.MapName = name;
            await _context.SaveChangesAsync();
        }

        public async Task PatchDescriptionMap(int id, string description)
        {
            var map = await _context.Maps.FindAsync(id);
            if (map == null) throw new GameNotFoundException(id);
            map.MapDescription = description;
            await _context.SaveChangesAsync();
        }

        public async Task PatchLatitudeMap(int id, double latitude)
        {
            var map = await _context.Maps.FindAsync(id);
            if (map == null) throw new GameNotFoundException(id);
            map.Latitude = latitude;
            await _context.SaveChangesAsync();
        }
        public async Task PatchLongitudeMap(int id, double longtitude)
        {
            var map = await _context.Maps.FindAsync(id);
            if (map == null) throw new GameNotFoundException(id);
            map.Longitude = longtitude;
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Delete
        /// <summary>
        /// Service for deleting a map.
        /// </summary>
        /// <param name="id">Identifier on the map.</param>
        /// <returns></returns>
        /// <exception cref="MapNotFoundException">When the given map do not exist.</exception>
        public async Task DeleteMap(int id)
        {
            Map? map = await _context.Maps.FindAsync(id);

            if (map == null) throw new MapNotFoundException(id);
            _context.Maps.Remove(map);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
