using System;
using System.IO;
using Newtonsoft.Json;
using ParseJson.DoAirPrice;
using ParseJson.DoAirPriceFee;
using ParseJson.DoBooking;


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

            }
            return genericobject;
        }        

    }
}

