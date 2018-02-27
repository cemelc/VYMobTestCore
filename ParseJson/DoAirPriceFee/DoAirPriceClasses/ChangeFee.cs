namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class ChangeFee
    {
        public object JourneySellKey { get; set; }
        public object FareSellKey { get; set; }
        public string GroupCode { get; set; }
        public string Code { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public bool IsInternational { get; set; }
        public decimal Percentage { get; set; }
        public string FeeCode { get; set; }
        public decimal Amount { get; set; }
    }
}
