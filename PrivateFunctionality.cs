using System;

public class PrivateFunctionality
{

    //************* PRIVATE FUNCTION EXECUTE OPERATIONAL SYNERGIES ************************/

    protected static double AppleTaxShields = 12140;
    protected static int AppleSharesOutstanding = 5865;
    protected static double ApplelongTermDebt = 16960;

    protected static double PioneerTaxShields = 17550;
    protected static int PioneerSharesOutstanding = 367;  // financial transaction includes selling Pioneer equity
    protected static double PioneerlongTermDebt = 15078;

    protected static double CombinedTaxShields = 12287;
    protected static int CombinedSharesOutstanding = 5865;  // Price per share will increase due to synergies
    protected static double CombinedlongTermDebt = 16960;   // raising capital through Pioneer equity transactions


    public PrivateFunctionality()
    {

    }


    protected double executeOperationalSynergies(double discountRate, double OperationalSynergyDecreaseinCost)
    {
        double custompegRate = 0.0920;
        double ProprietaryFreeCashFlow2014 = 41287 * OperationalSynergyDecreaseinCost;
        double ProprietaryFreeCashFlow2015 = ProprietaryFreeCashFlow2014 * (1 + custompegRate);
        double ProprietaryFreeCashFlow2016 = ProprietaryFreeCashFlow2015 * (1 + custompegRate);
        double ProprietaryFreeCashFlow2017 = ProprietaryFreeCashFlow2016 * (1 + custompegRate);
        double ProprietaryFreeCashFlow2018 = ProprietaryFreeCashFlow2017 * (1 + custompegRate);
        double TerminalValue = (ProprietaryFreeCashFlow2018 * (1 + custompegRate)) / (discountRate - custompegRate);

        double APV = Math.Round(ProprietaryFreeCashFlow2014 / (Math.Pow((1 + discountRate), 1)) +
                                 ProprietaryFreeCashFlow2015 / (Math.Pow((1 + discountRate), 2)) +
                                 ProprietaryFreeCashFlow2016 / (Math.Pow((1 + discountRate), 3)) +
                                 ProprietaryFreeCashFlow2017 / (Math.Pow((1 + discountRate), 4)) +
                                 (ProprietaryFreeCashFlow2018 + TerminalValue) / (Math.Pow((1 + discountRate), 5)), 2);
        return APV;
    }



    //************* PRIVATE FUNCTION EXECUTE MARKET SYNERGIES ************************/

    protected double executeMarketSynergies(double discountRate, double MarketSynergyIncreaseinNOPAT)
    {
        double custompegRate = 0.0920;
        double ProprietaryFreeCashFlow2014 = 43740 * MarketSynergyIncreaseinNOPAT;
        double ProprietaryFreeCashFlow2015 = ProprietaryFreeCashFlow2014 * (1 + custompegRate);
        double ProprietaryFreeCashFlow2016 = ProprietaryFreeCashFlow2015 * (1 + custompegRate);
        double ProprietaryFreeCashFlow2017 = ProprietaryFreeCashFlow2016 * (1 + custompegRate);
        double ProprietaryFreeCashFlow2018 = ProprietaryFreeCashFlow2017 * (1 + custompegRate);
        double TerminalValue = (ProprietaryFreeCashFlow2018 * (1 + custompegRate)) / (discountRate - custompegRate);

        double APV = Math.Round(ProprietaryFreeCashFlow2014 / (Math.Pow((1 + discountRate), 1)) +
                                 ProprietaryFreeCashFlow2015 / (Math.Pow((1 + discountRate), 2)) +
                                 ProprietaryFreeCashFlow2016 / (Math.Pow((1 + discountRate), 3)) +
                                 ProprietaryFreeCashFlow2017 / (Math.Pow((1 + discountRate), 4)) +
                                 (ProprietaryFreeCashFlow2018 + TerminalValue) / (Math.Pow((1 + discountRate), 5)), 2);
        return APV;
    }


    //************* PRIVATE FUNCTION EXECUTE PRICE PER SHARE ************************/
    protected double executePricePerShare(double APV, double taxShields, double longtermDebt, double SharesOutstanding, ref double pricePerShare)
    {

        double entityValuation = APV + taxShields;
        double equityValuation = entityValuation - longtermDebt;

        pricePerShare = Math.Round(equityValuation / SharesOutstanding, 2);

        return entityValuation;
    }

    //******************* PRIVATE FUNCTION EXECUTE VALIDATION *********************/
    protected double executeValuation(double ProprietaryFreeCashFlow2013, double ProprietaryFreeCashFlow2014, double ProprietaryFreeCashFlow2015, double ProprietaryFreeCashFlow2016, double ProprietaryFreeCashFlow2017, double ProprietaryFreeCashFlow2018, double TerminalValue, double ProprietaryDiscountRate)
    {
        double APV = Math.Round(ProprietaryFreeCashFlow2013 / (Math.Pow((1 + ProprietaryDiscountRate), 1)) +
                                    ProprietaryFreeCashFlow2014 / (Math.Pow((1 + ProprietaryDiscountRate), 2)) +
                                    ProprietaryFreeCashFlow2015 / (Math.Pow((1 + ProprietaryDiscountRate), 3)) +
                                    ProprietaryFreeCashFlow2016 / (Math.Pow((1 + ProprietaryDiscountRate), 4)) +
                                    ProprietaryFreeCashFlow2017 / (Math.Pow((1 + ProprietaryDiscountRate), 5)) +
                                    (ProprietaryFreeCashFlow2018 + TerminalValue) / (Math.Pow((1 + ProprietaryDiscountRate), 6)), 2);
        return APV;
    }


    //*******************************************************************************/

}


