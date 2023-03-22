using System.Runtime.Serialization;

namespace hvz_backend.Exceptions
{
    [Serializable]
    internal class PlayerNotFoundException : Exception
    {
        // Exception used in case of not finding a specific player.
        public PlayerNotFoundException(int id) : base($"Couldn't find player with ID: {id}") { }

        public PlayerNotFoundException() : base("Couldn't find players.") { }

    }
}