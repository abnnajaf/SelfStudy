using RulesEngine.Good2.Entity;
using RulesEngine.Good2.Interface;

namespace RulesEngine.Good2.Infrastructure.Rules
{
    public class WarehouseRule : IPaymentTypeRule
    {
        public void Compute(PaymentTypeComputation paymentType, Order order)
        {
            if (GetAvailableProduct(order))
                paymentType.NotAllowedTypes.Add(PaymentTypes.Online);
        }

        /// <summary>
        /// دریافت موجودی محصول از انبار
        /// </summary>
        /// <param name="markets"></param>
        /// <returns></returns>
        private static bool GetAvailableProduct(Order order)
        {
            return order.ProductId % 2 == 0;
        }
    }
}
