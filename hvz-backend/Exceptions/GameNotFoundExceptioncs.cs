namespace hvz_backend.Exceptions
{
    public class GameNotFoundException : Exception
    {
        // Exception used in case of not finding a specific game.
        public GameNotFoundException(int id) : base($"Couldn't find game with ID: {id}") { }
    }
}
