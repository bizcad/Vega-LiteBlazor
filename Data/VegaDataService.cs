using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Vega_LiteBlazor.Data
{
    public class VegaDataService
    {
        public async Task<VegaData[]> GetVegaData()
        {
            //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = startDate.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //}).ToArray());

            List<VegaData> list = new List<VegaData>();

            var t = await Task.Run<List<VegaData>>(() =>
            {

                list.Add(new VegaData() { a = 'A', b = 2 });
                list.Add(new VegaData() { a = 'B', b = 17 });
                list.Add(new VegaData() { a = 'C', b = 4 });
                list.Add(new VegaData() { a = 'D', b = 11 });
                list.Add(new VegaData() { a = 'E', b = 12 });
                list.Add(new VegaData() { a = 'F', b = 26 });
                list.Add(new VegaData() { a = 'G', b = 8 });
                list.Add(new VegaData() { a = 'H', b = 14 });
                list.Add(new VegaData() { a = 'I', b = 7 });
                return list;
            });
            await Task.Yield();
            return list.ToArray();

        }
    }
}
