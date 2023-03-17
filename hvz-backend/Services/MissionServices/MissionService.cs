using hvz_backend.Models;

namespace hvz_backend.Services.MissionServices
{
    public class MissionService : IMissionService
    {
        public Task<Mission> CreateMission(Mission mission)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Mission>> GetAllMissions()
        {
            throw new NotImplementedException();
        }

        public Task<Mission> GetMissionById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
