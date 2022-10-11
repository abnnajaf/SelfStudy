using RulesEngine.Good.Entity;
using RulesEngine.Good.Interface;
using System.Collections.Generic;

namespace RulesEngine.Good.Infrastructure
{
    /// <summary>
    /// انجین اصلی که تمامی رول ها را اجرا میکند
    /// </summary>
    public class TaxRuleEngine
    {
        private readonly IEnumerable<ITaxRule> rules;

        public TaxRuleEngine(IEnumerable<ITaxRule> rules)
        {
            this.rules = rules ?? new List<ITaxRule>();
        }

        public TaxPayer CalculateTaxAmount(TaxPayer taxPayer)
        {
            foreach (var rule in rules)
            {
                taxPayer.TaxedAmount += rule.CalculateTax(taxPayer).TaxedAmount;
            }
            return taxPayer;
        }
    }
}
