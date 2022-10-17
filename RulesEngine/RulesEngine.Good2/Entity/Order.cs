namespace RulesEngine.Good2.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public PriceTypes PriceType { get; set; }
        public Markets Market { get; set; }
    }
}