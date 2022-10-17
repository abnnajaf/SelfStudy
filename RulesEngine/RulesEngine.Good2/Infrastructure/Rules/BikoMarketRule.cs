using RulesEngine.Good2.Entity;
using RulesEngine.Good2.Interface;

namespace RulesEngine.Good2.Infrastructure.Rules
{
    public class BikoMarketRule : IPaymentTypeRule
    {
        public void Compute(PaymentTypeComputation paymentType, Order order)
        {
            if (order.Market != Markets.BikoPlus)
                return;

            paymentType.AllowedTypes.Add(PaymentTypes.Customer_Credit);
        }
    }
}
