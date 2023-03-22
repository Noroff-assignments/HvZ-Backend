using hvz_backend.Exceptions;
using hvz_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace hvz_backend.Services.MissionServices
{
    public class MissionService : IMissionService
    {
        #region Constrcutor & Fields
        private readonly HvZDbContext _context;

        public MissionService(HvZDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<Mission> CreateMission(Mission mission)
        {
            if (mission == null) throw new ArgumentNullException(nameof(mission));
            _context.Missions.Add(mission);
            await _context.SaveChangesAsync();
            return mission;
        }

        public async Task<IEnumerable<Mission>> GetAllMissionsInMap(int mapId)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var missions = map.Missions;
            if (missions == null) throw new MissionNotFoundException();
            return missions;
        }

        public async Task<Mission> GetMissionByIdInMap(int mapId, int id)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new MissionNotFoundException(id);
            return mission;
        }

        public async Task<Mission> UpdateMission(Mission mission)
        {
            var foundMission = await _context.Missions.AnyAsync(m => m.Id == mission.Id);
            if (!foundMission) throw new MissionNotFoundException(mission.Id);

            _context.Entry(mission).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return mission;
        }

        public async Task DeleteMission(int id)
        {
            Mission? mission = await _context.Missions.FindAsync(id);

            if (mission == null) throw new MissionNotFoundException(id);
            _context.Missions.Remove(mission);
            await _context.SaveChangesAsync();
        }
    }
}
