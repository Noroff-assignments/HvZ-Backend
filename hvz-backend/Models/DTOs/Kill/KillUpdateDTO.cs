
namespace hvz_backend.Models.DTOs.Kill
{
    public class KillUpdateDTO
    {
        public DateTime TimeDead { get; set; }
        public string? DeadStory { get; set; }
        public int KillerId { get; set; }
        public int VictimId { get; set; }
    }
}
