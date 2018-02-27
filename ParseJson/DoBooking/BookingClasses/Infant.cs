using System;


namespace ParseJson.DoBooking.BookingClasses
{
    public class Infant
    {
        public int Number { get; set; }
        public int PaxNumber { get; set; }
        public string PaxType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ResidenceCountry { get; set; }
        public int OrderView { get; set; }
        public int Type { get; set; }
        public bool isFrequent { get; set; }
        public object frequentOrder { get; set; }
        public bool saveAsFrequent { get; set; }
        public DateTime DOB { get; set; }
        public bool HasDni { get; set; }
        public int Parent { get; set; }
    }
}
