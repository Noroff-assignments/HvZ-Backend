using hvz_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MinLength(2), MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public StateAdmin Status { get; set; }


    }
}
