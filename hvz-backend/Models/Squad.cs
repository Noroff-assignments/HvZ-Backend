using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Squad
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int? TotalPlayer { get; set; }

        public int? TotalDead { get; set; }
        public int? GameId { get; set; }
        public Game? Game { get; set; }

        public ICollection<Player>? Players { get; set; }
    }
}
