using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    class VirtualWeightSensor : IWeightSensorInterface, ISensorInterface
    {
        private readonly Random Random;
        private readonly string SensorName;

        public VirtualWeightSensor(string SensorName)
        {
            Random = new Random();
            this.SensorName = SensorName;
        }

        public Weight Weight()
        {
            return new Weight(Random.Next(100), SensorName);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Weight());
        }
    }
}
