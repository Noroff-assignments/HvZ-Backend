using hvz_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace hvz_backend.Models.DTOs.Supply
{
    public class SupplyCreateDTO
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool ZombieVisible { get; set; }
        public bool HumanVisible { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MapId { get; set; }
        public ItemType Drop { get; set; }
        public int Amount { get; set; }
        public int Radius { get; set; }
    }
}
