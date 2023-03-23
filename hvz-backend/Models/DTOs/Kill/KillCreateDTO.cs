
namespace hvz_backend.Models.DTOs.Kill
{
    public class KillCreateDTO
    {
        public DateTime TimeDead { get; set; }
        public string? DeadStory { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int GameId { get; set; }
        public int KillerId { get; set; }
    }
}
