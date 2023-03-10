using hvz_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;


namespace hvz_backend.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        [Required, DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? BeginTime { get; set; }

        [Required, DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get; set; }

        [Required]
        public StateGame Status { get; set; }
    }
}
