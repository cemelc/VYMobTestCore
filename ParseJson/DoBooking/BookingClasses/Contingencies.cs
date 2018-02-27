
using System.Collections.Generic;


namespace ParseJson.DoBooking.BookingClasses
{
    public class Contingencies
    {
        public bool IsRefund { get; set; }
        public bool Active { get; set; }
        public List<object> AfectedJourneyList { get; set; }
        public bool ShowSpecialBox { get; set; }
        public object SpecialBoxKey { get; set; }
        public bool ShowChangeFlightInfoBox { get; set; }
        public object ChangeFlightInfoBoxKey { get; set; }
        public bool ShowRefoundInfoBox { get; set; }
        public bool ShowRefoundButton { get; set; }
        public object RefoundInfoBoxKey { get; set; }
        public bool AcceptProgrammedChangesEnabled { get; set; }
    }
}
