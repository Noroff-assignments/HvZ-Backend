
namespace hvz_backend.Models.DTOs.Player
{
    public class PlayerReadDTO
    {
        public int Id { get; set; }
        public int? SquadId { get; set; }
        public int GameId { get; set; }
        public string UserID { get; set; }
        public List<string>? KillsByMe { get; set; }
        public List<string>? KillsAgainstMe { get; set; }
    }
}
