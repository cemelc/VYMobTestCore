using System.Collections.Generic;

namespace ParseJson.DoAirPrice.DoAirPriceClasses
{
    public class Trip
    {
        public bool IsMac { get; set; }
        public string CurrencyCode { get; set; }
        public int DiscountType { get; set; }
        public List<JourneyMarket> JourneyMarkets { get; set; }
        public object AtvInfo { get; set; }
        public bool ShowRedressNumber { get; set; }
        public string BookingTypeAncillaries { get; set; }

    }    
}
