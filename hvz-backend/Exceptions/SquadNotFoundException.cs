using System.Runtime.Serialization;

namespace hvz_backend.Exceptions
{
    [Serializable]
    internal class SquadNotFoundException : Exception
    {
        // Exception used in case of not finding a specific squad.
        public SquadNotFoundException(int id) : base($"Couldn't find squad with ID: {id}") { }

        public SquadNotFoundException() : base("Couldn't find squads.") { }
    }
}