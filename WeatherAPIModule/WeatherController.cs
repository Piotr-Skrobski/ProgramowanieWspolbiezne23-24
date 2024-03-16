namespace WeatherAPIModule
{
    public class WeatherController
    {
        private readonly WeatherService _weatherService;

        public WeatherController()
        {
            _weatherService = new WeatherService();
        }

        public List<WeatherData> GetWeatherForecast(string location, int days)
        {
            return _weatherService.GenerateFakeWeatherForecast(location, days);
        }
    }
}
