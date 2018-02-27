using ParseJson.DoBooking.BookingClasses;
using System.Collections.Generic;


namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class ManagementFeePrice
    {
        public List<BreakDown> BreakDown { get; set; }
        public decimal Total { get; set; }
        public string CurrencyCode { get; set; }
        public bool HideTotal { get; set; }
    }
}

