using System.Collections.Generic;

namespace ParseJson.DoBooking.BookingClasses
{
    public class CheckinValidations
    {
        public bool NeedApis { get; set; }
        public bool NeedPhone { get; set; }
        public bool NeedEmail { get; set; }
        public string ClientEmail { get; set; }
        public List<ValidationsJourneyLevel> ValidationsJourneyLevel { get; set; }
    }

}
