

namespace ParseJson.DoBooking.BookingClasses
{
    public class ValidationsPaxLevel
    {
        public int PaxNumber { get; set; }
        public bool IsCheckinAllowed { get; set; }
        public bool ApiValidated { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public bool Checked { get; set; }
    }
}
