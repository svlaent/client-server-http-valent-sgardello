using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    class VirtualWeightSensor : IVirtualWeightSensorInterface, ISensorInterface
    {
        private readonly Random Random;

        public VirtualWeightSensor()
        {
            Random = new Random();
        }

        public int Weight()
        {
            return new Weight(Random.Next(100)).Value;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Weight());
        }
    }
}
