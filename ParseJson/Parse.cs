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

            if (patron == "file")
            {

                genericobject = JsonConvert.DeserializeObject<DirectoryofURL>(File.ReadAllText(filelocation));

            }
            if (patron == "DoAirPrice")
            {
                genericobject = JsonConvert.DeserializeObject<DoAirPriceRequest>(File.ReadAllText(filelocation));

            }

            if (patron == "DoAirPriceFee")
            {
                genericobject = JsonConvert.DeserializeObject<DoAirPriceFeeRequest>(File.ReadAllText(filelocation));

            }

            if (patron == "DoBooking")
            {
                genericobject = JsonConvert.DeserializeObject<DoBookingRequest>(File.ReadAllText(filelocation));

            }

            return genericobject;
        }

        public String StringGen(int len, int num)
        {
            String text = "";
            String alpha = "abcdefghijklmnopqrstuvwxyz";
            String alnum = "abcdefghijklmnopqrstuvwxyz0123456789";
            String onnum = "0123456789";
            var random = new Random();



            for (int i = 0; i < len; i++)
            {
                if (num == 1)
                {
                    text += alnum[random.Next(alnum.Length)];
                }
                if (num == 2)
                {
                    text += alpha[random.Next(alpha.Length)];
                }
                if (num == 3)
                {
                    text += onnum[random.Next(onnum.Length)];
                }
            }
            return text;
        }
    }
}

