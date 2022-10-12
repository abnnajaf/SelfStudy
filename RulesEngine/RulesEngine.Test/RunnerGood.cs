using RulesEngine.Good.Entity;
using RulesEngine.Good.Service;
using Xunit;

namespace RulesEngine.Test
{
    public class RunnerGood
    {
        private readonly TaxCalculatorService calculator = new TaxCalculatorService();

        [Fact]
        public void Income_For_Single_TaxPayer()
        {
            // Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                GrossIncome = 300_000,
                IsSingle = true,
                IsResidentOrCitizen = true,
            };

            // Act
            var result = calculator.CalculateTax(taxPayer);

            // Assert
            Assert.Equal(78_000, result.TaxedAmount);
        }
    }
}
