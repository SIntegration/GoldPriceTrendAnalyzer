using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldPriceTrendAnalyzer
{
  
        public class TrendAnalyzer
        {
            public string AnalyzeInterestRate(decimal rate)
            {
                if (rate > 3.5m)
                    return "Zinssatz steigend – das macht Gold weniger attraktiv, da Anleihen attraktiver werden.";
                else if (rate < 1.5m)
                    return "Zinssatz fallend – günstiger für Gold, da Investoren in den sicheren Hafen wechseln.";
                else
                    return "Zinssatz neutral – keine wesentlichen Auswirkungen erwartet.";
            }

            public string AnalyzeDollarIndex(decimal index)
            {
                if (index > 100)
                    return "Dollarindex steigend – für ausländische Käufer wird Gold teurer, was den Preis drücken könnte.";
                else if (index < 90)
                    return "Dollarindex fallend – dies könnte den Goldpreis stützen, da es für internationale Käufer günstiger wird.";
                else
                    return "Dollarindex neutral – keine wesentlichen Auswirkungen erwartet.";
            }

            public string AnalyzeInflationRate(decimal rate)
            {
                if (rate > 3.0m)
                    return "Inflationsrate steigend – dies erhöht die Nachfrage nach Gold als Inflationsschutz.";
                else if (rate < 1.0m)
                    return "Inflationsrate fallend – geringere Nachfrage nach Gold, da die Inflationserwartungen sinken.";
                else
                    return "Inflationsrate neutral – keine wesentlichen Auswirkungen erwartet.";
            }

            public string AnalyzeEconomicGrowthRate(decimal rate)
            {
                if (rate > 2.5m)
                    return "Wirtschaftswachstum steigend – höhere Nachfrage nach Aktien, was Kapital von Gold abziehen könnte.";
                else if (rate < 1.0m)
                    return "Wirtschaftswachstum fallend – Gold könnte als sicherer Hafen profitieren.";
                else
                    return "Wirtschaftswachstum neutral – keine wesentlichen Auswirkungen erwartet.";
            }
        }
}
