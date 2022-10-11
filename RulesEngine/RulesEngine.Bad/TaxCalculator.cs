using RulesEngine.Bad.Entity;
using System;

namespace RulesEngine.Bad
{
    public class TaxCalculator
    {
        public int CalculateTaxPercentage(TaxPayer taxPayer)
        {
            if (!taxPayer.TaxCitizen)
                throw new InvalidOperationException("No TAX Calculation");

            if (taxPayer.HasDisability)
            {
                return 0;
            }
            //
            if (taxPayer.IsMuslim)
            {
                if (taxPayer.ZakatPaid > 10000 && taxPayer.ZakatPaid < 50000)
                {
                    return 5;
                }
                if (taxPayer.ZakatPaid > 10000 && taxPayer.ZakatPaid < 100000)
                {
                    return 4;
                }
                if (taxPayer.ZakatPaid > 100000 && taxPayer.ZakatPaid < 200000)
                {
                    return 3;
                }
            }
            //
            if (taxPayer.IsRetired)
            {
                return 1;
            }

            return 0;
        }
    }
}
