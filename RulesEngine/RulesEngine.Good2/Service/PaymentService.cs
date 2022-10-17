using RulesEngine.Good2.Entity;
using RulesEngine.Good2.Infrastructure;
using RulesEngine.Good2.Interface;

namespace RulesEngine.Good2.Service
{
    public class PaymentService
    {
        public IEnumerable<PaymentTypes> GetPaymentTypes(Order order)
        {
            var ruleType = typeof(IPaymentTypeRule);
            var rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as IPaymentTypeRule);

            var engine = new RuleEngine(rules);

            // ایجاد مدل محاسبات نوع پرداخت
            PaymentTypeComputation paymentType = new();
            paymentType.AllowedTypes.AddRange(GetAllowedPaymentTypes());

            // اجرای تمامی رول های مالیاتی
            return engine.ComputationPaymentType(paymentType, order);
        }

        /// <summary>
        /// دریافت نوع پرداخت های مجاز
        /// </summary>
        /// <returns></returns>
        private IEnumerable<PaymentTypes> GetAllowedPaymentTypes()
        {
            List<PaymentTypes> paymentTypes = new()
            {
                PaymentTypes.Online ,
                PaymentTypes.PayAtHome ,
                PaymentTypes.Card ,
                PaymentTypes.Deposit ,
                PaymentTypes.Partner_Credit
            };
            return paymentTypes;

            return Enum.GetValues(typeof(PaymentTypes)).Cast<PaymentTypes>();
        }
    }
}
