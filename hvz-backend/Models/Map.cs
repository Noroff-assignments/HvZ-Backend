using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string MapName { get; set; }

        [MaxLength(255)]
        public string? MapDescription { get; set; }

        [Required, Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        [Required, Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public ICollection<Safezone> Safezones { get; set;}
        public ICollection<Mission> Missions { get; set; }
        public ICollection<Supply> Supplies { get; set; }


    }
}
