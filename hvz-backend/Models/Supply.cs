using hvz_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class Supply: Marker
    {

        [Required]
        public ItemType Drop { get; set; }

        public int Amount { get; set; }

    }
}
