namespace hvz_backend.Models.DTOs.Player
{
    public class PlayerUpdateDTO
    {
        public int? SquadId { get; set; }
        public int GameId { get; set; }
        public string UserID { get; set; }
    }
}
