using System;
using System.IO;
using Newtonsoft.Json;
using ParseJson.DoAirPrice;
using ParseJson.DoAirPriceFee;
using ParseJson.DoBooking;
using ParseJson.DoBooking.BookingClasses;
using ParseJson.Login;
using System.Xml;



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

        public String FindFiles(string filename)
        {
            string[] getfile;

            if (filename.Contains("xml") == true)
            {
                getfile = Directory.GetFiles(@".\", filename);
            }
            else
            {
                getfile = Directory.GetFiles(@".\Files", filename);
            }

            string filelocation = String.Join("", getfile);
            //log.Info("The file used is: " + filelocation);

            return filelocation;
        }


        public XmlDocument LoadLog4netXmlDocument(string path, string Environment, string ApplicationId)
        {

            if (string.IsNullOrEmpty(path))
                throw new Exception("Invalid log4net config path!!!");

            var xmlDoc = new XmlDocument();

            var xmlData = File.ReadAllText(path);


            xmlData = xmlData.Replace("{ApplicationId}", ApplicationId)
                         .Replace("{LogLevel}", "DEBUG")
                         .Replace("{Environment}", Environment);

            var xmlDataaux = xmlData;
            xmlDoc.LoadXml(xmlDataaux);
            return xmlDoc;

        }

    }
}

