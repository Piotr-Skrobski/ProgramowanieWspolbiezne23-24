using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIModule
{
    public class WeatherData
    {
        public string Location { get; }
        public DateTime Date { get; }
        public double Temperature { get; }
        public double Humidity { get; }
        public double WindSpeed { get; }

        public WeatherData(string location, DateTime date, double temperature, double humidity, double windSpeed)
        {
            Location = location;
            Date = date;
            Temperature = temperature;
            Humidity = humidity;
            WindSpeed = windSpeed;
        }
    }
}
