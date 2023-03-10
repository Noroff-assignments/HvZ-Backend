using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string BiteCode { get; set; }

        [Required]
        public bool IsZombie { get; set; }

        [Required]
        public bool IsPatientZero { get; set; }

    }
}
