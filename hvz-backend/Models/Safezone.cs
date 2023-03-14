using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace hvz_backend.Models
{
    public class Safezone : Marker
    {

        [Required, Range(1,50, ErrorMessage = "Radius must be between 1 and 50.")]
        public int Radius { get; set; }

    }
}
