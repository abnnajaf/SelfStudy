using RulesEngine.Good.Entity;
using RulesEngine.Good.Interface;

namespace RulesEngine.Good.Infrastructure.TaxRules
{
    public class SingleRule : ITaxRule
    {
        public TaxPayer CalculateTax(TaxPayer taxPayer)
        {
            if (taxPayer.IsSingle)
                taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40_000) * .1);
            return taxPayer;
        }
    }
}
