using System.Runtime.Serialization;

namespace hvz_backend.Exceptions
{
    [Serializable]
    internal class SafezoneNotFoundException : Exception
    {
        // Exception used in case of not finding a specific safezone.
        public SafezoneNotFoundException(int id) : base($"Couldn't find safezone with ID: {id}") { }

        public SafezoneNotFoundException() : base("Couldn't find safezones.") { }

    }
}