

namespace ParseJson.DoBooking.BookingClasses
{
    public class Fare
    {
        public string PaxType { get; set; }
        public string RuleNumber { get; set; }
        public string ProductClass { get; set; }
        public string SellKey { get; set; }
        public double Amount { get; set; }
        public double FarePrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public int AvailableCount { get; set; }
        public bool IsPromo { get; set; }
    }
}
