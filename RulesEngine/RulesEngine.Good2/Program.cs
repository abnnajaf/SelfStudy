using RulesEngine.Good2.Entity;
using RulesEngine.Good2.Service;
using System.IO;


while (true)
{
    var order = new Order();

    try
    {
        Console.WriteLine("Enter the market :");
        var market = Convert.ToInt32(Console.ReadLine());
        order.Market = (Markets)market;
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid Market !!!!!");
    }

    //Console.Clear();
    Console.WriteLine("Entered the market : " + (Markets)order.Market);

    try
    {
        Console.WriteLine("Enter the productId :");
        var productId = Convert.ToInt32(Console.ReadLine());
        order.ProductId = productId;
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid PriceType !!!!!");
    }

    try
    {
        Console.WriteLine("Enter the price type :");
        var priceType = Convert.ToInt32(Console.ReadLine());
        order.PriceType = (PriceTypes)priceType;
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid PriceType !!!!!");
    }

    var paymentService = new PaymentService();
    var paymentTypes = paymentService.GetPaymentTypes(order);

    Console.WriteLine(Environment.NewLine);
    var index = 1;
    foreach (var type in paymentTypes)
    {
        Console.WriteLine($"{index++} : {type}");
    }
    Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);
}
