using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models.DTOs.Kill
{
    public class KillCreateDTO
    {
        public DateTime TimeDead { get; set; }
        public string? DeadStory { get; set; }
        public int GameId { get; set; }
        public int KillerId { get; set; }
        public int VictimId { get; set; }

    }
}
