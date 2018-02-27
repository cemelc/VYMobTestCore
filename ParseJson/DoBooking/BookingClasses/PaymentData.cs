
using System.Collections.Generic;


namespace ParseJson.DoBooking.BookingClasses
{
    public class PaymentData
    {
        public object PaymentMethodType { get; set; }
        public string PaymentMethodCode { get; set; }
        public string QuotedCurrencyCode { get; set; }
        public string AccountNumber { get; set; }
        public string Expiration { get; set; }
        public string PaymentAddresses { get; set; }
        public List<PaymentFieldsList> PaymentFieldsList { get; set; }
    }
}
