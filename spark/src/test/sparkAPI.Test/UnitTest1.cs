using System;
using Xunit;
using sparkAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace sparkAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetWeatherForecastDetails()
        {
            var returnValue = controller.Get(1);
            Assert.Contains("temperatureC",returnValue.ToString());
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
