using hvz_backend.Models;

namespace hvz_backend.Services.MissionServices
{
    public interface IMissionService
    {
        Task<Mission> CreateMission(Mission mission);
        Task<IEnumerable<Mission>> GetAllMissionsInMap(int mapId);
        Task<Mission> GetMissionByIdInMap(int mapId, int id);
        Task<Mission> UpdateMission(Mission mission);
        Task DeleteMission(int id);
    }
}
