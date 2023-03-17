using hvz_backend.Models;

namespace hvz_backend.Services.MissionServices
{
    public interface IMissionService
    {
        Task<IEnumerable<Mission>> GetAllMissions();
        Task<Mission> GetMissionById(int id);
        Task<Mission> CreateMission(Mission mission);
    }
}
