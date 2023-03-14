using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models
{
    public class KillVictim
    {
        public int Id { get; set; }
        public int VictimId { get; set; }
        public Kill Kill { get; set; }

        /*public int KillId { get; set; }
        public Kill Kill { get; set; }

        public int VictimId { get; set; }
        public Player Victim { get; set; }*/
    }
}