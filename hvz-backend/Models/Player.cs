using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required,Range(1000,9999)]
        public int BiteCode { get; set; }
        [Required]
        public bool IsZombie { get; set; }
        [Required]
        public bool IsPatientZero { get; set; }

        [Required, Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        [Required, Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

        public int SquadId { get; set; }
        public Squad Squad { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        [Required]
        public string UserID { get; set; }
        public ICollection<Kill>? KillsByMe { get; set; }
        public ICollection<Kill>? KillsAgainstMe { get; set; }

    }
}
