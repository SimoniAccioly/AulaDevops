using AulaDevops;
using AulaDevops.Controllers;

namespace testApi
{
    public class WeatherForecastTeste
    {
        [Fact]
        public void DeveFazerGetComSucesso()
        {
            var controller = new WeatherForecastController();

            var result = controller.Get();

            Assert.True(result.Any());
        }


        [Fact]
        public void DeveRetornarListaValidaDePrevisoesTempo()
        {

            var controller = new WeatherForecastController();

            var result = controller.Get();

            Assert.True(result.Any());

            Assert.Equal(5, result.Count());

            var currentDate = DateTime.Now;
            foreach (var forecast in result)
            {
                Assert.True(forecast.Date > currentDate);
            }

            foreach (var forecast in result)
            {
                Assert.InRange(forecast.TemperatureC, -20, 55);
            }

            foreach (var forecast in result)
            {
                Assert.Contains(forecast.Summary, controller.Summaries);
            }
        }
    }
}