using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Kill
    {
        [Key]
        public int Id { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TimeDead { get; set; }

        [MaxLength(150)]
        public string? DeadStory { get; set; }

        [Required, Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        [Required, Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int KillerId { get;  set; }

        public Player Killer { get; set; }

        public int VictimId { get; set; }

        public Player Victim { get; set; }

    }
}
