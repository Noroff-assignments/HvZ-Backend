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

        public enum State
        {
            Active,
            Inactive
        }

    }
}
