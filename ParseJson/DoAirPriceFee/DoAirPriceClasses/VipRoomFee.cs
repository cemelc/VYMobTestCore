using System;

namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class VipRoomFee
    {
        public string SegmentSellKey { get; set; }
        public DateTime Date { get; set; }
        public int IsNoSchengen { get; set; }
        public string StationCode { get; set; }
        public string VipRoomType { get; set; }
        public string Code { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
    }
}
