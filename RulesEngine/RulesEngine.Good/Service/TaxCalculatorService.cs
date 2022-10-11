using RulesEngine.Good.Entity;
using RulesEngine.Good.Infrastructure;
using RulesEngine.Good.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RulesEngine.Good.Service
{
    /// <summary>
    /// سرویس محاسبه کننده مالیات
    /// </summary>
    public class TaxCalculatorService
    {
        /// <summary>
        /// محاسبه مالیات
        /// </summary>
        /// <param name="taxPayer"></param>
        /// <returns></returns>
        public TaxPayer CalculateTax(TaxPayer taxPayer)
        {
            // دریافت لیست تمام قوانین ای که از اینترفیس رول ارث بری کرده اند
            var ruleType = typeof(ITaxRule);
            IEnumerable<ITaxRule> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as ITaxRule);

            var engine = new TaxRuleEngine(rules);

            // اجرای تمامی رول های مالیاتی
            return engine.CalculateTaxAmount(taxPayer);
        }
    }
}
