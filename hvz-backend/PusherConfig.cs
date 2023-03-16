namespace hvz_backend
{
    static class PusherConfig
    {
        private static string? _apiId;
        private static string? _apiKey;
        private static string? _apiSecret;

        public static string? ApiId { get => _apiId; set => _apiId = value; }
        public static string? ApiKey { get => _apiKey; set => _apiKey = value; }
        public static string? ApiSecret { get => _apiSecret; set => _apiSecret = value; }
    }
}
