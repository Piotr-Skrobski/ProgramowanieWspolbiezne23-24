using WeatherAPIModule;

namespace WeatherModule
{
    internal class Program
    {
        static void printData(List<WeatherData> forecast)
        {
            foreach (var data in forecast)
            {
                Console.WriteLine("Prognoza dla dnia: " + data.Date + " i miasta " + data.Location);
                Console.WriteLine("Temperatura wynosi: " + data.Temperature.ToString("F2") + " C");
                Console.WriteLine("Wilgotnosc to: " + data.Humidity.ToString("F1") + "%");
                Console.WriteLine("Predkosc wiatru: " + data.WindSpeed.ToString("F1") + " km/h");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            WeatherController controller = new WeatherController();
            List<WeatherData> data = controller.GetWeatherForecast("Łódź", 2);
            printData(data);

        }
    }
}
