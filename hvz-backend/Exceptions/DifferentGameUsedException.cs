namespace hvz_backend.Exceptions
{
    public class DifferentGameUsedException : Exception
    {
        public DifferentGameUsedException() : base("Trying to use object across different games.") { }
    }
}
