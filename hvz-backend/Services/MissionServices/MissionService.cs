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

        #region Create
        public async Task<Mission> CreateMission(Mission mission)
        {
            if (mission == null) throw new ArgumentNullException(nameof(mission));
            _context.Missions.Add(mission);
            await _context.SaveChangesAsync();
            return mission;
        }
        #endregion

        #region Get
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
        #endregion

        #region Update
        public async Task<Mission> UpdateMission(Mission mission)
        {
            var foundMission = await _context.Missions.AnyAsync(m => m.Id == mission.Id);
            if (!foundMission) throw new MissionNotFoundException(mission.Id);

            _context.Entry(mission).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return mission;
        }

        public async Task PatchTitleMission(int mapId, int id, string title)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.Title = title;
            await _context.SaveChangesAsync();
        }

        public async Task PatchDescriptionMission(int mapId, int id, string description)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.Description = description;
            await _context.SaveChangesAsync();
        }

        public async Task PatchLatMission(int mapId, int id, double lat)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.Latitude = lat;
            await _context.SaveChangesAsync();
        }

        public async Task PatchLongMission(int mapId, int id, double lon)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.Longitude = lon;
            await _context.SaveChangesAsync();
        }

        public async Task PatchZombieMission(int mapId, int id, bool zombieVisible)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.ZombieVisible = zombieVisible;
            await _context.SaveChangesAsync();
        }

        public async Task PatchHumanMission(int mapId, int id, bool humanVisible)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.HumanVisible = humanVisible;
            await _context.SaveChangesAsync();
        }

        public async Task PatchBeginMission(int mapId, int id, DateTime beginTime)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.BeginTime = beginTime;
            await _context.SaveChangesAsync();
        }

        public async Task PatchEndMission(int mapId, int id, DateTime endTime)
        {
            var map = await _context.Maps
                .Include(m => m.Missions)
                .Where(k => k.Id == mapId)
                .FirstOrDefaultAsync();
            if (map == null) throw new GameNotFoundException(mapId);
            var mission = map.Missions.FirstOrDefault(k => k.Id == id);
            if (mission == null) throw new KillNotFoundException(id);
            mission.EndTime = endTime;
            await _context.SaveChangesAsync();
        }

        #endregion

        #region Delete
        public async Task DeleteMission(int id)
        {
            Mission? mission = await _context.Missions.FindAsync(id);

            if (mission == null) throw new MissionNotFoundException(id);
            _context.Missions.Remove(mission);
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
