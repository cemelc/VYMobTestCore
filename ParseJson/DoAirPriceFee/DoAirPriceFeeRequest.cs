using System.Collections.Generic;
using ParseJson.DoAirPrice.DoAirPriceClasses;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;


namespace ParseJson.DoAirPriceFee
{

    public class DoAirPriceFeeRequest
    {
        public DoAirPriceFeeRequest()
        {
            SellKeyList = new List<SellKeyList>();
            PaxInfoList = new List<Pax>();
        }

        public List<SellKeyList> SellKeyList { get; set; }
        public string DiscountType { get; set; }
        public List<Pax> PaxInfoList { get; set; }
        public string CurrencyCode { get; set; }
        public DoBooking.BookingClasses.PaymentData PaymentData { get; set; }
        public string Signature { get; set; }
        public string Udid { get; set; }
        public string DeviceType { get; set; }
        public string UserAgent { get; set; }
        public string TokenID { get; set; }
        public string Language { get; set; }
    }
}
