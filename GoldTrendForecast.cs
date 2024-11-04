using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldPriceTrendAnalyzer
{
        public class GoldTrendForecast
        {
            private readonly TrendAnalyzer analyzer = new TrendAnalyzer();

            public void GenerateForecast(MarketData data)
            {
                Console.WriteLine("Gold Trend-Analyse:");

                Console.WriteLine(analyzer.AnalyzeInterestRate(data.InterestRate));
                Console.WriteLine(analyzer.AnalyzeDollarIndex(data.DollarIndex));
                Console.WriteLine(analyzer.AnalyzeInflationRate(data.InflationRate));
                Console.WriteLine(analyzer.AnalyzeEconomicGrowthRate(data.EconomicGrowthRate));

                // Schätzung der Goldpreis-Tendenz
                var positiveFactors = 0;
                var negativeFactors = 0;

                if (data.InterestRate < 1.5m) positiveFactors++;
                else if (data.InterestRate > 3.5m) negativeFactors++;

                if (data.DollarIndex < 90) positiveFactors++;
                else if (data.DollarIndex > 100) negativeFactors++;

                if (data.InflationRate > 3.0m) positiveFactors++;
                else if (data.InflationRate < 1.0m) negativeFactors++;

                if (data.EconomicGrowthRate < 1.0m) positiveFactors++;
                else if (data.EconomicGrowthRate > 2.5m) negativeFactors++;

                if (positiveFactors > negativeFactors)
                    Console.WriteLine("\nGesamtprognose: Goldpreis in den nächsten Tagen wahrscheinlich steigend.");
                else if (negativeFactors > positiveFactors)
                    Console.WriteLine("\nGesamtprognose: Goldpreis in den nächsten Tagen wahrscheinlich fallend.");
                else
                    Console.WriteLine("\nGesamtprognose: Keine wesentliche Veränderung des Goldpreises erwartet.");
            }
        }



}

