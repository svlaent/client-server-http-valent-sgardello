namespace NetCoreClient.ValueObjects
{
    internal class Speed
    {
        public int Value { get; private set; }
        public string Type { get; private set; }
        public Speed(int value, string type)
        {
            this.Value = value;
            this.Type = type;
        }
    }
}
