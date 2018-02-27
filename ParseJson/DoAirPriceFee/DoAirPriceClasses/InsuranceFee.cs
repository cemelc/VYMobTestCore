
namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class InsuranceFee
    {
        public bool Enabled { get; set; }
        public string InsurancePolicyLink { get; set; }
        public decimal InfantAmount { get; set; }
        public bool MustRecalculate { get; set; }
        public string Code { get; set; }
        public decimal Percentage { get; set; }
        public double Amount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
