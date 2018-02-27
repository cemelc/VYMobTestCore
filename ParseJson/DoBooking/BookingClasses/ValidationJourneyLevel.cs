
using System.Collections.Generic;

namespace ParseJson.DoBooking.BookingClasses
{
    public class ValidationsJourneyLevel
    {
        public string Status { get; set; }
        public string JourneySellKey { get; set; }
        public bool IsCheckinAllowed { get; set; }
        public string Info { get; set; }
        public string Link { get; set; }
        public List<ValidationsPaxLevel> ValidationsPaxLevel { get; set; }
    }

}
