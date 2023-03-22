using System.Runtime.Serialization;

namespace hvz_backend.Exceptions
{
    [Serializable]
    internal class SupplyNotFoundException : Exception
    {
        // Exception used in case of not finding a specific supply.
        public SupplyNotFoundException(int id) : base($"Couldn't find supply with ID: {id}") { }

        public SupplyNotFoundException() : base ("Couldn't find supplies.") { }
    }
}