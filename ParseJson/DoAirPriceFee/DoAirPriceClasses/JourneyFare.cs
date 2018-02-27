
namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
        public class JourneyFare
        {
            public double Amount { get; set; }
            public string PromoType { get; set; }
            public string ProductClass { get; set; }
            public string JourneyFareKey { get; set; }
            public bool IsFareAvailable { get; set; }
            public int AvailableCount { get; set; }
            public bool IsPromo { get; set; }
            public bool IsPromoVYAplicable { get; set; }
            public bool Active { get; set; }
            public int ColumnId { get; set; }
            public string CurrencyCode { get; set; }
        }    
}

