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

        public int? SquadId { get; set; }
        public Squad? Squad { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        [Required]
        public string UserToken { get; set; }

        public ICollection<Kill>? KillsByMe { get; set; }
        public ICollection<Kill>? KillsAgainstMe { get; set; }

    }
}
