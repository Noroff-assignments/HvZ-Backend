using System.Runtime.Serialization;

namespace hvz_backend.Exceptions
{
    [Serializable]
    internal class MapNotFoundException : Exception
    {
        // Exception used in case of not finding a specific map.
        public MapNotFoundException(int id) : base($"Couldn't find map with ID: {id}") { }

        public MapNotFoundException() : base("Couldn't find maps.") { }

    }
}