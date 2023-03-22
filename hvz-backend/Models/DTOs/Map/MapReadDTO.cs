namespace hvz_backend.Models.DTOs.Map
{
    public class MapReadDTO
    {
        public int Id { get; set; }
        public string MapName { get; set; }
        public string? MapDescription { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public List<string>? Safezones { get; set; }
        public List<string>? Missions { get; set; }
        public List<string>? Supplies { get; set; }
    }
}
