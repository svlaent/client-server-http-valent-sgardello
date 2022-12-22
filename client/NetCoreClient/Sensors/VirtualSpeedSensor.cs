using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    class VirtualSpeedSensor : ISpeedSensorInterface, ISensorInterface
    {
        private readonly Random Random;
        private readonly string SensorName;

        public VirtualSpeedSensor(string SensorName)
        {
            Random = new Random();
            this.SensorName = SensorName;
        }

        public Speed Speed()
        {
            return new Speed(Random.Next(100), SensorName);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Speed());
        }
    }
}
