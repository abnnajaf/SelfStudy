using RulesEngine.Good.Entity;

namespace RulesEngine.Good.Interface
{
    /// <summary>
    /// اینترفیس یک رول جدید
    /// </summary>
    public interface ITaxRule
    {
        /// <summary>
        /// متد محاسبه کننده برای رول نوشته شده
        /// </summary>
        /// <param name="taxPayer"></param>
        /// <returns></returns>
        TaxPayer CalculateTax(TaxPayer taxPayer);
    }
}
