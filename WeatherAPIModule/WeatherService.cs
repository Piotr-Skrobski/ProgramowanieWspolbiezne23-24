using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIModule
{
    public class WeatherService
    {
        private readonly Random _random;
        public WeatherService()
        {
            _random = new Random();
        }

        public List<WeatherData> GenerateFakeWeatherForecast(string location, int days)
        {
            List<WeatherData> forecast = new List<WeatherData>();

            for (int i = 0; i < days; i++)
            {
                DateTime date = DateTime.Today.AddDays(i);
                double temperature = GenerateRandomTemperature();
                double humidity = GenerateRandomHumidity();
                double windSpeed = GenerateRandomWindSpeed();

                forecast.Add(new WeatherData(location, date, temperature, humidity, windSpeed));
            }

            return forecast;
        }

        private double GenerateRandomTemperature()
        {
            return _random.NextDouble() * (60) + (-20);
        }

        private double GenerateRandomHumidity()
        {
            return _random.NextDouble() * 100;
        }

        private double GenerateRandomWindSpeed()
        {
            return _random.NextDouble() * 30;
        }
    }
}
