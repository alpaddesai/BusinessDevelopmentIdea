using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            double MarketDiscountRateApple = .117558;
            double MarketDiscountRatePioneer = .15344;
            double MarketDisocuntRateSynergies = MarketDiscountRateApple;  // The discount ratio utilized for the valuation of the combined firm with synergies is that of the buyer corporation. 
            double currencyExchangeRate = 0.0084;
            double MarketSynergyIncreaseinNOPAT = 0.0125;
            double OperationalSynergyDecreaseinCost = 0.0009;

            AppleFinancialsProjection2014 analysis = new AppleFinancialsProjection2014();

            analysis.valuationAppleVariable = analysis.AlpaAppleProprietaryValuation(MarketDiscountRateApple);
            analysis.valuationPioneerVariable = analysis.AlpaPioneerProprietaryValuation(MarketDiscountRatePioneer);
            analysis.valuationVariable = analysis.AlpaSynergiesProprietaryValuation(MarketDisocuntRateSynergies, MarketSynergyIncreaseinNOPAT, OperationalSynergyDecreaseinCost);

            analysis.printInformation( analysis, currencyExchangeRate);


            MarketDiscountRateApple = .118558;
            MarketDiscountRatePioneer = .16344;
            MarketSynergyIncreaseinNOPAT = 0.015;

            analysis.valuationAppleVariable = analysis.AlpaAppleProprietaryValuation(MarketDiscountRateApple);
            analysis.valuationPioneerVariable = analysis.AlpaPioneerProprietaryValuation(MarketDiscountRatePioneer);
            analysis.valuationVariable = analysis.AlpaSynergiesProprietaryValuation(MarketDisocuntRateSynergies, MarketSynergyIncreaseinNOPAT, OperationalSynergyDecreaseinCost);

            analysis.printInformation(analysis, currencyExchangeRate);

            MarketDiscountRateApple = .117558;
            MarketDiscountRatePioneer = .15344;
            MarketSynergyIncreaseinNOPAT = 0.0125;
            currencyExchangeRate = 0.0089;

            analysis.valuationAppleVariable = analysis.AlpaAppleProprietaryValuation(MarketDiscountRateApple);
            analysis.valuationPioneerVariable = analysis.AlpaPioneerProprietaryValuation(MarketDiscountRatePioneer);
            analysis.valuationVariable = analysis.AlpaSynergiesProprietaryValuation(MarketDisocuntRateSynergies, MarketSynergyIncreaseinNOPAT, OperationalSynergyDecreaseinCost);

            analysis.printInformation(analysis, currencyExchangeRate);


        }


    }
}


/*   PRINTED OUTPUT
 
 
 Synergy Analysis with Apple Financials Projected from 2014 onwards:

 Dashboard value of Apple Valuation is  $USD 674554.42 million and price per share is $112.12
 Dashboard value of Pioneer Valuation  is  Yen 141037.74 million and price per share is Yen 343.21
 Dashboard value of Pioneer Valuation is  $USD 1184.72 million and price per share is $ 2.88
 Dashboard value of Combined Entity Valuation  is  $USD 684600.78 million and price per share is $USD 117 with
 Market Synergies of $USD 9268.55 million and  Operational Synergies of $USD 629.91 million

 Synergy Analysis with Apple Financials Projected from 2014 onwards:

 Dashboard value of Apple Valuation is  $USD 671426.9 million and price per share is $111.59
 Dashboard value of Pioneer Valuation  is  Yen 134613.6 million and price per share is Yen 325.71
 Dashboard value of Pioneer Valuation is  $USD 1130.75 million and price per share is $ 2.74
 Dashboard value of Combined Entity Valuation  is  $USD 686454.49 million and price per share is $USD 117 with
 Market Synergies of $USD 11122.26 million and  Operational Synergies of $USD 629.91 million

 Synergy Analysis with Apple Financials Projected from 2014 onwards:

 Dashboard value of Apple Valuation is  $USD 674554.42 million and price per share is $112.12
 Dashboard value of Pioneer Valuation  is  Yen 141037.74 million and price per share is Yen 343.21
 Dashboard value of Pioneer Valuation is  $USD 1255.24 million and price per share is $ 3.05
 Dashboard value of Combined Entity Valuation  is  $USD 684600.78 million and price per share is $USD 117 with
 Market Synergies of $USD 9268.55 million and  Operational Synergies of $USD 629.91 million

  
     
     */



