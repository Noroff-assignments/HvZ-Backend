
namespace hvz_backend.Models.DTOs.Kill
{
    public class KillReadDTO
    {
        public int Id { get; set; }
        public int gameId { get; set; }
        public DateTime TimeDead { get; set; }
        public string? DeadStory { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int KillerId { get; set; }
        public int VictimId { get; set; }
    }
}
