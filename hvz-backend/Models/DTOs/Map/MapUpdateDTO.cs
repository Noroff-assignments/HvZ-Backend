namespace hvz_backend.Models.DTOs.Map
{
    public class MapUpdateDTO
    {
        public string MapName { get; set; }
        public string? MapDescription { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Radius { get; set; }
    }
}
