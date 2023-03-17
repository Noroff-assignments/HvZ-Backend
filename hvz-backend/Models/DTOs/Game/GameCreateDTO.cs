using hvz_backend.Models.Enums;

namespace hvz_backend.Models.DTOs.Game
{
    public class GameCreateDTO
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MapId { get; set; }
        public string AdminID { get; set; }
    }
}
