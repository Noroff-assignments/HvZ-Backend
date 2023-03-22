namespace hvz_backend.Exceptions
{
    public class KillNotFoundException : Exception
    {
        // Exception used in case of not finding a specific kill.
        public KillNotFoundException(int id) : base($"Couldn't find kill with ID: {id}") { }

        public KillNotFoundException() : base("Couldn't find kills.") { }

    }
}
