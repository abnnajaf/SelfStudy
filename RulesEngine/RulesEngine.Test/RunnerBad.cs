using RulesEngine.Bad;
using RulesEngine.Bad.Entity;
using System;
using Xunit;

namespace RulesEngine.Test
{
    public class RunnerBad
    {
        [Fact]
        public void Disable_Taxpayer_SHOULD_Pay_Zero_Percent_Tax()
        {
            // Arrange
            var taxPayer = new TaxPayer
            {
                TaxCitizen = true,
                HasDisability = true
            };
            var individualTaxCalculator = new TaxCalculator();

            // Act
            var Result = individualTaxCalculator.CalculateTaxPercentage(taxPayer);

            // Assert
            Assert.Equal(0, Result);
        }


        [Fact]
        public void None_TaxResident_SHOULD_NOT_BE_Calculated()
        {
            // Arrange
            var taxPayer = new TaxPayer
            {
                TaxCitizen = false
            };
            var individualTaxCalculator = new TaxCalculator();

            // Act
            string expectedErrorMessage = "No TAX Calculation";

            var Exception_Result = Assert.Throws<InvalidOperationException>(() =>
            individualTaxCalculator.CalculateTaxPercentage(taxPayer));

            // Assert
            Assert.Equal(expectedErrorMessage, Exception_Result.Message);
        }
    }
}
