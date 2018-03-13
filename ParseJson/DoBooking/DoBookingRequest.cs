using System;
using System.Collections.Generic;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoBooking.BookingClasses;


namespace ParseJson.DoBooking
{  

    public class DoBookingRequest
    {
        public string DiscountType { get; set; }
        public List<SellKeyList> SellKeyList { get; set; }
        public List<PaxInfoList> PaxInfoList { get; set; }
        public List<object> SeatInfoList { get; set; }
        public List<object> BagInfoList { get; set; }
        public List<VipRoomRequest> VipRoom { get; set; }
        public List<InsuranceRequest> Insurance { get; set; }
        public string CurrencyCode { get; set; }
        public BookingContact BookingContact { get; set; }
        public PaymentData PaymentData { get; set; }
        public List<Segment> segmentInfo { get; set; }
        public List<Journey> JourneyList { get; set; }
        public int TripType { get; set; }
        public bool DoCommit { get; set; }
        public string DeviceFingerPrint { get; set; }
        public string DeviceType { get; set; }
        public string Language { get; set; }
        public string Signature { get; set; }
        public string Udid { get; set; }
        public string UserAgent { get; set; }
        public string TokenID { get; set; }

        public static explicit operator DoBookingRequest(Journey v)
        {
            throw new NotImplementedException();
        }
    }

}
