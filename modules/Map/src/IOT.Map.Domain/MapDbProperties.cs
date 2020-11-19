namespace IOT.Map
{
    public static class MapDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Map";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Map";
    }
}
