using ParseJson.DoBooking.BookingClasses;
using System.Collections.Generic;


namespace ParseJson
{
    public class PromoFeePrice
    {
        public List<BreakDown> BreakDown { get; set; }
        public decimal Total { get; set; }
        public string CurrencyCode { get; set; }
        public bool HideTotal { get; set; }
    }
}

