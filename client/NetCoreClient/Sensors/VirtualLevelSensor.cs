using NetCoreClient.ValueObjects;
using System.Text.Json;

namespace NetCoreClient.Sensors
{
    class VirtualLevelSensor : ILevelSensorInterface, ISensorInterface
    {
        private readonly Random Random;
        private readonly string SensorName;

        public VirtualLevelSensor(string SensorName)
        {
            Random = new Random();
            this.SensorName = SensorName;
        }

        public Level Level()
        {
            return new Level(Random.Next(100), SensorName);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(Level());
        }

        public string GetSlug()
        {
            return "level";
        }
    }
}
