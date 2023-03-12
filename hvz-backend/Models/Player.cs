using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required,Range(100000000,999999999)]
        public int BiteCode { get; set; }

        [Required]
        public bool IsZombie { get; set; }

        [Required]
        public bool IsPatientZero { get; set; }

        public int? SquadId { get; set; }
        public Squad? Squad { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
