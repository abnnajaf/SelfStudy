using RulesEngine.Good2.Entity;
using RulesEngine.Good2.Interface;

namespace RulesEngine.Good2.Infrastructure.Rules
{
    public class PriceTypeRule : IPaymentTypeRule
    {
        public void Compute(PaymentTypeComputation paymentType, Order order)
        {
            if (order.PriceType == PriceTypes.Amazing)
                paymentType.NotAllowedTypes.Add(PaymentTypes.PayAtHome);
        }
    }
}
