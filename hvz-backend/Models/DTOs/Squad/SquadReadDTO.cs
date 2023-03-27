namespace hvz_backend.Models.DTOs.Squad
{
    public class SquadReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalPlayer { get; set; }
        public int TotalDead { get; set; }

        public List<string> Players { get; set; }
    }
}
