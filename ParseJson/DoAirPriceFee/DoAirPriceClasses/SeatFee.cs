
namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class SeatFee
    {
        public string SegmentSellKey { get; set; }
        public string SeatGroup { get; set; }
        public string Code { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
