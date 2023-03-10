using hvz_backend.Models.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.ComponentModel.DataAnnotations;

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

        [Required, DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime TimeStamp { get; set; }

    }
}
