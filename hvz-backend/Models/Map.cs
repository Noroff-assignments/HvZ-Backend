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

    }
}
