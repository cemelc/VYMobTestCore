using System;


namespace ParseJson.DoBooking.BookingClasses
{
    public class BookingInfo
    {
        public string ChannelType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime BookingDate { get; set; }
        public string PaidStatus { get; set; }
        public string BookingPaymentStatus { get; set; }
        public DateTime PaymentDeadline { get; set; }
    }

}
