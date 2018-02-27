using System.Collections.Generic;


namespace ParseJson.DoBooking.BookingClasses
{
    public class BreakdownItineraryV2
    {
        public List<DoAirPriceFee.DoAirPriceClasses.JourneysPrice> JourneysPrice { get; set; }
        public DoAirPriceFee.DoAirPriceClasses.ExtraServicePrice ExtraServicePrice { get; set; }
        public DoAirPriceFee.DoAirPriceClasses.ManagementFeePrice ManagementFeePrice { get; set; }
        public PromoFeePrice PromoFeePrice { get; set; }
        public string CurrencyCode { get; set; }
        public object PromoDetail { get; set; }
        public bool HideTotal { get; set; }
        public double TotalAmount { get; set; }
    }
}
