

namespace ParseJson.DoBooking.BookingClasses
{
    public class PriceClassMap
    {
        public double Amount { get; set; }
        public string PromoType { get; set; }
        public string ProductClass { get; set; }
        public decimal ManageFee { get; set; }
        public decimal ManageFeeDiscount { get; set; }
        public string JourneyFareKey { get; set; }
        public bool ShowManageFeeOnStv { get; set; }
        public bool IsFareAvailable { get; set; }
        public int AvailableCount { get; set; }
        public string PaxType { get; set; }
        public int PaxQt { get; set; }
        public double FarePrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public bool IsPromo { get; set; }
        public bool IsPromoVYAplicable { get; set; }
        public bool Active { get; set; }
        public int ColumnId { get; set; }
        public string CurrencyCode { get; set; }
    }

}
