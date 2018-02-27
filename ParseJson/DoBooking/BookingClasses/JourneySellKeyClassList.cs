using System;

namespace ParseJson.DoBooking.BookingClasses
{
    public class JourneySellKeyClassList
    {
        public string Format { get; set; }
        public string CarrierCode { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureStation { get; set; }
        public DateTime STD { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime STA { get; set; }
        public string Key { get; set; }
        public int JourneyNumber { get; set; }
    }
}
