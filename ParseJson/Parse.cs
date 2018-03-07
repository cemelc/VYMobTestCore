using System;
using System.IO;
using Newtonsoft.Json;
using ParseJson.DoAirPrice;
using ParseJson.DoAirPriceFee;
using ParseJson.DoBooking;
using ParseJson.DoBooking.BookingClasses;
using ParseJson.Login;


namespace ParseJson
{
    public class Parse
    {
        // Load the file

        public object FileRequest(string filelocation, string patron)
        {
            object genericobject = new object();

            switch (patron)
            {
                case "file":
                    genericobject = JsonConvert.DeserializeObject<DirectoryofURL>(File.ReadAllText(filelocation));
                    break;
                case "DoAirPrice":
                    genericobject = JsonConvert.DeserializeObject<DoAirPriceRequest>(File.ReadAllText(filelocation));
                    break;
                case "DoAirPriceFee":
                    genericobject = JsonConvert.DeserializeObject<DoAirPriceFeeRequest>(File.ReadAllText(filelocation));
                    break;
                case "DoBooking":
                    genericobject = JsonConvert.DeserializeObject<DoBookingRequest>(File.ReadAllText(filelocation));
                    break;
                case "Login":
                    genericobject = JsonConvert.DeserializeObject<LoginRequest>(File.ReadAllText(filelocation));
                    break;
                case "Payment":
                    genericobject = JsonConvert.DeserializeObject<PaymentEnviroment>(File.ReadAllText(filelocation));
                    break;

            }
            return genericobject;
        }        

    }
}

