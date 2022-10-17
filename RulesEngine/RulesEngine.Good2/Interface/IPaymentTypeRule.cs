using RulesEngine.Good2.Entity;

namespace RulesEngine.Good2.Interface
{
    public interface IPaymentTypeRule
    {
        void Compute(PaymentTypeComputation  paymentType, Order order);
    }
}
