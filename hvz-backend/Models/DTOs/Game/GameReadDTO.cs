using hvz_backend.Models.Enums;


namespace hvz_backend.Models.DTOs.Game
{
    public class GameReadDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }

        public StateGame Status { get; set; }

        //many to one
        public List<string>? Kills { get; set; }
        public List<string>? Players { get; set; }
        public List<string>? Squads { get; set; }

        public Map Map { get; set; }
    }
}
