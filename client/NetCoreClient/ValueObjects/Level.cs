namespace NetCoreClient.ValueObjects
{
    internal class Level
    {
        public int Value { get; private set; }
        public String Type { get; private set; }
        
        public Level(int value, string type)
        {
            this.Value = value;
            this.Type = type;
        }

    }
}
