using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }

        [Required, Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        [Required, Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

        [Required]
        public bool ZombieVisible { get; set; }

        [Required]
        public bool HumanVisible { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? BeginTime { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get; set; }

    }
}
