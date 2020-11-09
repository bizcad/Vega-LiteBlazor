/*
 * Data Service for the Vega-Lite chart embedded in the razor page
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vega_LiteBlazor.Data
{
    public class VegaDataService
    {
        /// <summary>
        /// Gets Data for the chart
        /// </summary>
        /// <returns>An array of data coordinates</returns>
        public async Task<VegaData[]> GetVegaData()
        {
            List<VegaData> list = new List<VegaData>();

            // use Task.Run so we can get an await in the async function
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
            //await Task.Yield();
            return list.ToArray();

        }
    }
}
