using System.Runtime.Serialization;

namespace hvz_backend.Exceptions
{
    [Serializable]
    internal class MissionNotFoundException : Exception
    {
        // Exception used in case of not finding a specific mission.
        public MissionNotFoundException(int id) : base($"Couldn't find mission with ID: {id}") { }

        public MissionNotFoundException() : base("Couldn't find missions.") { }

    }
}