namespace ParseJson.DoBooking.BookingClasses
{
    public class BreakDown
    {
        public int Quantity { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public double UPrice { get; set; }
        public string Info { get; set; }
        public string Type { get; set; }
        public string Style { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsPrevius { get; set; }
    }
}
