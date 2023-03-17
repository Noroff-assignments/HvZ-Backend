using hvz_backend.Models;

namespace hvz_backend.Services.SquadServices
{
    public interface ISquadService
    {
        Task<IEnumerable<Squad>> GetAllSquads();
        Task<Squad> GetSquadById(int id);
        Task<Squad> CreateSquad(Squad squad);
    }
}
