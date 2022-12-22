
namespace NetCoreClient.ValueObjects
{
    internal class Weight
    {
        public int Value { get; private set; }
        public string Type { get; private set; }
        public Weight(int value, string type)
        {
            this.Value = value;
            this.Type = type;
        }
    }
}
