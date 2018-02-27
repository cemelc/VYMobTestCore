
namespace ParseJson.DoBooking.BookingClasses
{
    public class PaxSSRList
    {  

        public string ActionStatusCode { get; set; }
        public int PassengerNumber { get; set; }
        public string SSRCode { get; set; }
        public int SSRNumber { get; set; }
        public int SSRValue { get; set; }
        public object Override { get; set; }
        public object ArrivalStation { get; set; }
        public object DepartureStation { get; set; }
        public object SSRDetail { get; set; }
        public object Note { get; set; }
    }

}
