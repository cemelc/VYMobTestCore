using System.Collections.Generic;
using ParseJson.DoBooking.BookingClasses;

namespace ParseJson.DoBooking
{
    public class PaymentEnviroment
    {
        public PaymentEnviroment() {
            var PRE = new PaymentData();
            var INT = new PaymentData();
            var PRO = new PaymentData();

        }

        public List<PaymentData> PRE { get; set; }
        public List<PaymentData> INT { get; set; }
        public List<PaymentData> PRO { get; set; }        
    }
}
