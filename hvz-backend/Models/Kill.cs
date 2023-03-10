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

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int KillerId { get; set; }
        public Player Killer { get; set; }

        public int VictimId { get; set; }
        public Player Victim { get; set; }
    }
}
