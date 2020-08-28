using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OBJwriteinJSON
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }

        static void Main(string[] args)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(WeatherForecast);
            jsonString = JsonSerializer.Serialize(WeatherForecast);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
