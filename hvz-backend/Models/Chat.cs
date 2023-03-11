using hvz_backend.Models.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hvz_backend.Models
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Message { get; set; }

        [Required]
        public ChatMode Mode { get; set; }

        [Required, DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime TimeStamp { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int? PlayerId { get; set; }
        public Player? Player { get; set; }

    }
}
