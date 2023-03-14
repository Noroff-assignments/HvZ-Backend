using hvz_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;


namespace hvz_backend.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }

        [Required, DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime BeginTime { get; set; }

        [Required, DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get; set; }

        [Required]
        public StateGame Status { get; set; }

        //many to one
        public ICollection<Kill>? Kills { get; set;}
        public ICollection<Player>? Players { get;set;}
        public ICollection<Squad>? Squads { get; set; }

        // one to many
        public int AdminId { get; set; }
        public Admin Admin { get; set; }

        //one to one
        public Chat Chat { get; set; }
        public Map Map { get; set; }
    }
}
