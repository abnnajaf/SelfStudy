using Composites.Good.Infrastructure;
using Composites.Good.Internet;
using Xunit;

namespace Composites.Test
{
    public class Runner
    {
        [Fact]
        public void RunAsset()
        {
            // Arrange

            // Create Leaf Object
            IComponent cpu = new Leaf("cpu", 10);
            IComponent ram = new Leaf("ram", 20);
            IComponent hardDisk = new Leaf("hardDisk", 5);
            IComponent mouse = new Leaf("mouse", 4);
            IComponent keyboard = new Leaf("keyboard", 66);

            // Create composite object
            IComponent motherBoard = new Composite("motherBoard");
            IComponent cabinet = new Composite("cabinet");
            IComponent peripherals = new Composite("peripherals");

            // Whole device
            IComponent computer = new Composite("computer");

            // Create tree structure
            motherBoard.AddComponents(cpu, ram);
            cabinet.AddComponents(motherBoard, hardDisk);
            peripherals.AddComponents(mouse, keyboard);

            computer.AddComponents(cabinet, peripherals);

            // Act
            var price = computer.CalculatePrice();

            // Arrange
            Assert.Equal(105, price);
        }
    }
}
