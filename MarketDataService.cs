using GoldPriceTrendAnalyzer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldPriceTrendAnalyzer
{
    public class MarketDataService
    {
        private readonly string apiKey = "DEIN_API_KEY";
        private readonly HttpClient client = new HttpClient();

        public async Task<MarketData> GetMarketDataAsync()
        {
            var response = await client.GetStringAsync($"https://api.example.com/marketdata?apikey={apiKey}");
            return JsonConvert.DeserializeObject<MarketData>(response);
        }
    }
}