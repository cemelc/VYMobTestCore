

namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class BagFee
    {
        public int Quantity { get; set; } 
        public decimal DiscountAmount { get; set; } 
        public string Code { get; set; } 
        public decimal Percentage { get; set; } 
        public decimal Amount { get; set; } 
        public string CurrencyCode { get; set; } 
    }
}
