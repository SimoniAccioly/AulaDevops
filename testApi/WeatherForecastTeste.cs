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
        public void DeveRetornarListaVaziaQuandoNenhumaPrevisaoEncontrada()
        {

            var controller = new WeatherForecastController();

            controller.Summaries = new string[0];

            var result = controller.Get();

            Assert.Empty(result);
        }
    }
}