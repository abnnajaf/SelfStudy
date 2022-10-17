using RulesEngine.Good2.Entity;
using RulesEngine.Good2.Interface;

namespace RulesEngine.Good2.Infrastructure
{
    public class RuleEngine
    {
        private readonly IEnumerable<IPaymentTypeRule> rules;

        public RuleEngine(IEnumerable<IPaymentTypeRule> rules)
        {
            this.rules = rules;
        }

        public IEnumerable<PaymentTypes> ComputationPaymentType(PaymentTypeComputation paymentType, Order order)
        {
            List<PaymentTypes> paymentTypes = new List<PaymentTypes>();

            foreach (var rule in rules)
            {
                rule.Compute(paymentType, order);
            }

            // محاسبه اشتراک
            foreach (var item in paymentType.AllowedTypes)
            {
                if (!paymentType.NotAllowedTypes.Contains(item))
                    paymentTypes.Add(item);
            }

            return paymentTypes.Distinct().OrderBy(x => x).ToList();
        }
    }
}
