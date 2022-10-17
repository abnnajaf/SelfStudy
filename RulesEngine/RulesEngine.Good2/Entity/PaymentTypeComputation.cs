namespace RulesEngine.Good2.Entity
{
    public class PaymentTypeComputation
    {
        public List<PaymentTypes> AllowedTypes { get; set; } = new List<PaymentTypes>();
        public List<PaymentTypes> NotAllowedTypes { get; set; } = new List<PaymentTypes>();
    }
}
