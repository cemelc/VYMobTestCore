using System.Collections.Generic;


namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class PaymentAlternativeFee
    {
        public string Description { get; set; }
        public object CvvLength { get; set; }
        public object BinLength { get; set; }
        public string Code { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public List<BanksList> BanksList { get; set; }
    }
}
