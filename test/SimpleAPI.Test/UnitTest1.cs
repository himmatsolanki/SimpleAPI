using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetDateByAddingIndex()
        {
            var item = controller.GetById(1);

            Assert.Equal(DateTime.Now.AddDays(2).Date, item.Date.Date);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
