using hvz_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(1), MaxLength(50)]
        public string NickName { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        public StateUser? State { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
