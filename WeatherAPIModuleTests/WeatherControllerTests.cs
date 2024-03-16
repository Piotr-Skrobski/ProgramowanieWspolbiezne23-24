using WeatherAPIModule;

namespace WeatherAPIModuleTests
{
    [TestClass]
    public class WeatherControllerTests
    {
        [TestMethod]
        public void GetWeatherForecast_ReturnsValidData()
        {
            WeatherController controller = new WeatherController();
            string location = "New York";
            int days = 100;

            List<WeatherData> forecast = controller.GetWeatherForecast(location, days);

            Assert.IsNotNull(forecast);
            Assert.AreEqual(days, forecast.Count);
            foreach (var data in forecast)
            {
                Assert.AreEqual(location, data.Location);
                Assert.IsTrue(data.Date >= DateTime.Today);
                Assert.IsTrue(data.Temperature >= -20 && data.Temperature <= 40);
                Assert.IsTrue(data.Humidity >= 0 && data.Humidity <= 100);
                Assert.IsTrue(data.WindSpeed >= 0 && data.WindSpeed <= 30);
            }
        }
    }
}