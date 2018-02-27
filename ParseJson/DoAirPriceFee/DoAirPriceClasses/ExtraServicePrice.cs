using System.Collections.Generic;
using ParseJson.DoBooking.BookingClasses;


namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class ExtraServicePrice
    {
        public List<BreakDown> BreakDown { get; set; }
        public decimal Total { get; set; }
        public string CurrencyCode { get; set; }
        public bool HideTotal { get; set; }
    }
}


