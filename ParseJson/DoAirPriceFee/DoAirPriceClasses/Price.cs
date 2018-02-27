using System.Collections.Generic;


namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class Price
    {
        public List<JourneysPrice> JourneysPrice { get; set; }
        public ExtraServicePrice ExtraServicePrice { get; set; }
        public ManagementFeePrice ManagementFeePrice { get; set; }
        public PromoFeePrice PromoFeePrice { get; set; }
        public string CurrencyCode { get; set; }
        public object PromoDetail { get; set; }
        public bool HideTotal { get; set; }
        public double TotalAmount { get; set; }
    }
}
