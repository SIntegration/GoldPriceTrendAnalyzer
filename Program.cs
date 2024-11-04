namespace GoldPriceTrendAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            static async Task Main(string[] args)
            {
                var dataService = new MarketDataService();
                var forecast = new GoldTrendForecast();

                try
                {
                    var marketData = await dataService.GetMarketDataAsync();
                    forecast.GenerateForecast(marketData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fehler beim Abrufen der Marktdaten: " + ex.Message);
                }
            }
        }
    }
}

