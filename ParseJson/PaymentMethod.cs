using ParseJson.DoBooking.BookingClasses;
using ParseJson.DoBooking;

namespace ParseJson
{
    public class PaymentMethod
    {
        public PaymentData Payment(string type, string ENV) {

            
            Parse parsing = new Parse();
            PaymentData selectedmethod = new PaymentData();
            FileManager Fileobject = new FileManager();
            string filelocationDoAirPrice = Fileobject.FindFiles("*PaymentMethods.json");
            var Empty = parsing.FileRequest(filelocationDoAirPrice, "Payment");
            PaymentEnviroment credaitcardinfoobject = (PaymentEnviroment)Empty;

            switch (ENV)
            {
                case "PRE":
                    foreach (var item in credaitcardinfoobject.PRE)
                    {
                        if (item.PaymentMethodCode == type) {
                            selectedmethod = item;
                        }
                    }
                    break;
                case "INV":
                    foreach (var item in credaitcardinfoobject.INT)
                    {
                        if (item.PaymentMethodCode == type)
                        {
                            selectedmethod = item;
                        }
                    }
                    break;
                case "PRO":
                    foreach (var item in credaitcardinfoobject.PRO)
                    {
                        if (item.PaymentMethodCode == type)
                        {
                            selectedmethod = item;/ right
                        }
                    }
                    break;
            }
            return selectedmethod;
        }
    }
}
