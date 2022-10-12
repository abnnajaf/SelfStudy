using Composites.Good.Internet;
using System;

namespace Composites.Good.Infrastructure
{
    public class Leaf : IComponent
    {
        public string Name { get; }
        public int Price { get; }

        public Leaf(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void AddComponents(params IComponent[] component)
        {
            throw new NotImplementedException();
        }

        public int CalculatePrice()
        {
            return Price;
        }
    }
}
