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

        Task PatchTitleMission(int mapId, int id, string title);
        Task PatchDescriptionMission(int mapId, int id, string description);

        Task PatchLatMission(int mapId, int id, double latitude);
        Task PatchLongMission(int mapId, int id, double longitude);

        Task PatchZombieMission(int mapId, int id, bool zombieVisible);
        Task PatchHumanMission(int mapId, int id, bool humanVisible);

        Task PatchBeginMission(int mapId, int id, DateTime beginTime);
        Task PatchEndMission(int mapId, int id, DateTime endTime);
        Task PatchRadiusMission(int mapId, int id, int radius);


    }
}
