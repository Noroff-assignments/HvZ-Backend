using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Map
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MapSeed { get; set; }

        [Required, MaxLength(50)]
        public string MapName { get; set; }

        [MaxLength(255)]
        public string? MapDescription { get; set; }

        [Required, Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        [Required, Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

    }
}
