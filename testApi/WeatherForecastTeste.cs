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

            controller.Summaries = Array.Empty<string>();

            var result = controller.Get();

            Assert.Empty(result);
        }
    }
}