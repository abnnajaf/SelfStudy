using Composites.Good.Internet;
using System.Collections.Generic;

namespace Composites.Good.Infrastructure
{
    public class Composite : IComponent
    {
        public string Name { get; }
        private readonly List<IComponent> components = new List<IComponent>();

        public Composite(string name)
        {
            Name = name;
        }

        public void AddComponents(params IComponent[] component)
        {
            components.AddRange(component);
        }

        public int CalculatePrice()
        {
            int totalPrice = 0;
            foreach (var component in components)
            {
                totalPrice += component.CalculatePrice();
            }
            return totalPrice;
        }
    }
}
