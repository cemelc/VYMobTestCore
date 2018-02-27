
using System.Collections.Generic;


namespace ParseJson.DoBooking.BookingClasses
{
    public class Success
    {
        public string RecordLocator { get; set; }
        public string Status { get; set; }
        public double TotalCost { get; set; }
        public decimal BalanceDue { get; set; }
        public string CurrencyCode { get; set; }
        public int PaxCount { get; set; }
        public bool ChangeSeatAllowed { get; set; }
        public bool ChangeFlightAllowed { get; set; }
        public int TripType { get; set; }
        public int DiscountType { get; set; }
        public List<JourneySellKeyClassList> JourneySellKeyClassList { get; set; }
        public List<DoAirPriceFee.DoAirPriceClasses.SellKeyList> SellKeyList { get; set; }
        public List<DoAirPriceFee.DoAirPriceClasses.Journey> JourneyList { get; set; }
        public List<PaxInfoList> PaxInfoList { get; set; }
        public List<object> SeatInfoList { get; set; }
        public BookingContact BookingContact { get; set; }
        public BookingInfo BookingInfo { get; set; }
        public BreakdownItineraryV2 BreakdownItineraryV2 { get; set; }
        public object ExternalPayments { get; set; }
        public bool HasInformativeJourneys { get; set; }
    }
}
