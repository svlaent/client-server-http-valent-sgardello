
namespace NetCoreClient.ValueObjects
{
    internal class Weight
    {
        public int Value { get; private set; }

        public Weight(int value)
        {
            this.Value = value;
        }
    }
}
