using RulesEngine.Good2.Entity;
using RulesEngine.Good2.Interface;

namespace RulesEngine.Good2.Infrastructure.Rules
{
    internal class ShopBusinessRule : IPaymentTypeRule
    {
        public void Compute(PaymentTypeComputation paymentType, Order order)
        {
            // مجاز
            paymentType.AllowedTypes.Add(PaymentTypes.Online);
            paymentType.AllowedTypes.Add(PaymentTypes.PayAtHome);

            // غیر مجاز
            paymentType.NotAllowedTypes.Add(PaymentTypes.NotDefine);
            paymentType.NotAllowedTypes.Add(PaymentTypes.Card);
            paymentType.NotAllowedTypes.Add(PaymentTypes.Deposit);
            paymentType.NotAllowedTypes.Add(PaymentTypes.Partner_Credit);
        }
    }
}