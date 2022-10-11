namespace RulesEngine.Good.Entity
{
    public class TaxPayer
    {
        /// <summary>
        /// در آمد نا خالص
        /// </summary>
        public double GrossIncome { get; set; }
        public bool IsSingle { get; set; }

        /// <summary>
        /// باز نشسته هست
        /// </summary>
        public bool IsRetired { get; set; }
        
        /// <summary>
        /// مقیم یا شهروند است
        /// </summary>
        public bool IsResidentOrCitizen { get; set; }
        public bool HasHealthInsurance { get; set; }
        public bool HasBusiness { get; set; }
        public bool AtLossInBusiness { get; set; }
        public double HealthInsuranceAnnualPremium { get; set; }
        public double TaxedAmount { get; set; }
    }
}
