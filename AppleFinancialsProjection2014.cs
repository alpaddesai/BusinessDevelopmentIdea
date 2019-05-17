using System;



public class AppleFinancialsProjection2014: PrivateFunctionality  // inherits all functions/methods
{
    
 
    public double ApplePricePerShare {get; set; }
    public double valuationAppleVariable { get; set; }
    public double PioneerPricePerShare { get; set; }
    public double valuationPioneerVariable { get; set; }

    public double combinedEntityPricerPerShare { get; set; }
    public double valuationVariable { get; set; }

    public double marketSynergies { get; set; }
    public double OperationalSynergies { get; set; }





    public AppleFinancialsProjection2014()
    {
    }

    public double AlpaAppleProprietaryValuation(double discountRate)
    {


        // values are in currency Dollar millions private variables
        double ProprietarFreeCashFlow2013 = 32879;
        double ProprietarFreeCashFlow2014 = 41287;
        double ProprietarFreeCashFlow2015 = 44917;
        double ProprietarFreeCashFlow2016 = 48806;
        double ProprietarFreeCashFlow2017 = 52959;
        double ProprietarFreeCashFlow2018 = 57377;
        double TerminalValue = 928550;
        double ProprietaryDiscountRate = discountRate;
        double PricePerShare=0;

        double APV = executeValuation(ProprietarFreeCashFlow2013, ProprietarFreeCashFlow2014, ProprietarFreeCashFlow2015, ProprietarFreeCashFlow2016, ProprietarFreeCashFlow2017, ProprietarFreeCashFlow2018, TerminalValue, discountRate);

        double entityValuation = executePricePerShare(APV, AppleTaxShields, ApplelongTermDebt, AppleSharesOutstanding, ref PricePerShare);

        ApplePricePerShare = PricePerShare;
        return entityValuation;
    }

    //*******************************************************************************/


    public double AlpaPioneerProprietaryValuation(double discountRate)
    {


        // values are in currency Yen millions private variables
        double ProprietaryFreeCashFlow2013 = -16347;
        double ProprietaryFreeCashFlow2014 = 1714;
        double ProprietaryFreeCashFlow2015 = 8077;
        double ProprietaryFreeCashFlow2016 = 14886;
        double ProprietaryFreeCashFlow2017 = 22164;
        double ProprietaryFreeCashFlow2018 = 29940;
        double TerminalValue = 233436;
        double PricePerShare=0;

        double APV = executeValuation(ProprietaryFreeCashFlow2013, ProprietaryFreeCashFlow2014, ProprietaryFreeCashFlow2015, ProprietaryFreeCashFlow2016, ProprietaryFreeCashFlow2017, ProprietaryFreeCashFlow2018, TerminalValue, discountRate);

        double entityValuation = executePricePerShare(APV, PioneerTaxShields, PioneerlongTermDebt, PioneerSharesOutstanding,  ref PricePerShare);

        PioneerPricePerShare = PricePerShare;

        return entityValuation;
    }

    //*******************************************************************************/


    public double AlpaSynergiesProprietaryValuation(double discountRate, double MarketSynergyIncreaseinNOPAT, double OperationalSynergyDecreaseinCost)
    {


        // values in $USD, millions, private variables
        double ProprietaryFreeCashFlow2013 = 32880;
        double ProprietaryFreeCashFlow2014 = 41287;
        double ProprietaryFreeCashFlow2015 = 44917;
        double ProprietaryFreeCashFlow2016 = 48806;
        double ProprietaryFreeCashFlow2017 = 52959;
        double ProprietaryFreeCashFlow2018 = 57377;
        double TerminalValue = 928550;
 

        double APV = executeValuation(ProprietaryFreeCashFlow2013, ProprietaryFreeCashFlow2014, ProprietaryFreeCashFlow2015, ProprietaryFreeCashFlow2016, ProprietaryFreeCashFlow2017, ProprietaryFreeCashFlow2018, TerminalValue, discountRate);


        marketSynergies = executeMarketSynergies(discountRate, MarketSynergyIncreaseinNOPAT);

        OperationalSynergies = executeOperationalSynergies(discountRate, OperationalSynergyDecreaseinCost);

        double entityValuation = APV + marketSynergies + OperationalSynergies + CombinedTaxShields;

        combinedEntityPricerPerShare = Math.Round(entityValuation / CombinedSharesOutstanding);

        return entityValuation;


    }

    public int printInformation(AppleFinancialsProjection2014 analysis, double currencyExchangeRate)
    {
        Console.WriteLine($"\n Synergy Analysis with Apple Financials Projected from 2014 onwards: \n");



        Console.WriteLine($" Dashboard value of Apple Valuation is  $USD {analysis.valuationAppleVariable} million and price per share is ${analysis.ApplePricePerShare}");
        Console.WriteLine($" Dashboard value of Pioneer Valuation  is  Yen {analysis.valuationPioneerVariable} million and price per share is Yen {analysis.PioneerPricePerShare}");
        Console.WriteLine($" Dashboard value of Pioneer Valuation is  $USD {Math.Round((analysis.valuationPioneerVariable * currencyExchangeRate), 2)} million and price per share is $ {Math.Round(((analysis.PioneerPricePerShare) * currencyExchangeRate), 2)}");

        Console.WriteLine($" Dashboard value of Combined Entity Valuation  is  $USD {analysis.valuationVariable} million and price per share is $USD {analysis.combinedEntityPricerPerShare} with ");
        Console.WriteLine($" Market Synergies of $USD {analysis.marketSynergies} million and  Operational Synergies of $USD {analysis.OperationalSynergies} million     ");

        Console.ReadKey();

        return 0;
    }




    //************************ ENCAPSULATED INTERFACE NOT ACCESSIBLE TO THE USER ***********************************/

}  // end of class ApplesFinancialProjections
