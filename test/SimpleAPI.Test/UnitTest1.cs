using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetDateByAddingIndex()
        {
            var item = controller.GetById(1);

            Assert.Equal(DateTime.Now.AddDays(1).Date, item.Date.Date);
        }

        [Fact]
        public void Test1()
        {
            var list = controller.Get();
            Assert.True(list.Count() > 0);
        }
    }
}
