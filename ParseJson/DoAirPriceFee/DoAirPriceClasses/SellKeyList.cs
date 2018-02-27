
using ParseJson.DoBooking.BookingClasses;
using System.Collections.Generic;


namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class SellKeyList
    {
        public string FareKey { get; set; }
        public string JourneyKey { get; set; }
        public object OldJourneyKey { get; set; }
        public int JourneyNumber { get; set; }
        public object Override { get; set; }
        public List<PaxSSRList> PaxSSRList { get; set; }
    }
}

