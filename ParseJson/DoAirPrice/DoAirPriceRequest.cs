using System.Collections.Generic;
using ParseJson.DoAirPrice.DoAirPriceClasses;

namespace ParseJson.DoAirPrice
{

    public class DoAirPriceRequest
    {
        //public bool IsCompletPrice { get; set; }
        public string CurrencyCode { get; set; }
        //public string FlightType { get; set; }
        public List<Pax> Paxs { get; set; }
        public int DiscountType { get; set; }
        public List<AirportDateTimeList> AirportDateTimeList { get; set; }
        //public string Signature { get; set; } 
        //public string Udid { get; set; } 
        public string DeviceType { get; set; }
        //public string UserAgent { get; set; }
        //public string TokenID { get; set; } 
        public string PromoCode { get; set; }
        public string Language { get; set; }
        public string AppVersion { get; set; }
    }
}
