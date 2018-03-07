
using System.Collections.Generic;


namespace ParseJson.DoBooking.BookingClasses
{
    public class PaymentData
    {

        private string _paymentToken;

        public PaymentData() {
            PaymentFieldsList = new List<PaymentFieldsList>();
        }

        public object PaymentMethodType { get; set; }
        public string PaymentMethodCode { get; set; }
        public string QuotedCurrencyCode { get; set; }
        public decimal QuotedAmount { get; set; }
        public string AccountNumber { get; set; }
        public string IssuerId { get; set; }
        public string Expiration { get; set; }
        public string PaymentAddresses { get; set; }
        public List<PaymentFieldsList> PaymentFieldsList { get; set; }

        public string ApplePayToken
        {
            get { return _paymentToken; }
            set { _paymentToken = value; }
        }

        public string PaymentToken
        {
            get { return _paymentToken; }
            set { _paymentToken = value; }
        }
    }
}


