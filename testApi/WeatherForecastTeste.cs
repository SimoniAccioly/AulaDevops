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

            Assert.True(result.Count() > 0);
        }
    }
}