using RulesEngine.Good.Entity;
using RulesEngine.Good.Interface;

namespace RulesEngine.Good.Infrastructure.TaxRules
{
    public class IncomeRule : ITaxRule
    {
        public TaxPayer CalculateTax(TaxPayer taxPayer)
        {
            if (taxPayer.GrossIncome < 40000)
                taxPayer.TaxedAmount = 0;
            else
            {
                taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40_000) * .1);
            }
            return taxPayer;
        }
    }
}
