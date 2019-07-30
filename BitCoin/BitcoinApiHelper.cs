using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BitCoin
{
    public class BitcoinApiHelper
    {
        private const string BASEURL = "https://www.mercadobitcoin.net/api/";

        public async Task<List<Trade>> GetTrades()
        {
            var client = new HttpClient();
            string result = "";
            client.BaseAddress = new Uri(BASEURL);

            var response = client.GetAsync("BTC/trades/").Result;

            if (response.IsSuccessStatusCode)
                result = response.Content.ReadAsStringAsync().Result;

            return ConvertToTrade(result);
        }

        private List<Trade> ConvertToTrade(string json)
        {
            var settings = new JsonSerializerSettings
            {
                CheckAdditionalContent = true
            };

            var trades = JsonConvert.DeserializeObject<List<Trade>>(json, settings);

            //trades.Reverse();

            return trades;
        }
    }
}
