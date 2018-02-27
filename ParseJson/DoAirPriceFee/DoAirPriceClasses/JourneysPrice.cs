
using System.Collections.Generic;

namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class JourneysPrice
    {
        public string JourneySellKey { get; set; }
        public string FareType { get; set; }
        public List<JourneyPrice> JourneyPrice { get; set; }
        public double TotalJourney { get; set; }
        public bool HideTotal { get; set; }
        public string CurrencyCode { get; set; }
        public string OperatedBy { get; set; }
    }
}

