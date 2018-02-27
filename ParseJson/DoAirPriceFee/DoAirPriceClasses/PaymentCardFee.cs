
namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class PaymentCardFee
    {
        public string Description { get; set; }
        public string CvvLength { get; set; }
        public string BinLength { get; set; }
        public string Code { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
