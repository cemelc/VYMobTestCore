using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ParseJson
{
    class RandomGenerator
    {
        private static Random random = new Random();
        public static string RandomString(int length, int type)
        {
            string text = string.Empty;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string alpha = "abcdefghijklmnopqrstuvwxyz";
            const string onnum = "0123456789";
            switch (type)
            {
                case 1:
                    text = new string(Enumerable.Repeat(chars, length)
                       .Select(s => s[random.Next(s.Length)]).ToArray());
                    break;
                case 2:
                    text = new string(Enumerable.Repeat(alpha, length)
                       .Select(s => s[random.Next(s.Length)]).ToArray());
                    break;
                case 3:
                    text = new string(Enumerable.Repeat(onnum, length)
                       .Select(s => s[random.Next(s.Length)]).ToArray());
                    break;
            }
            return text;
        }

        public static List<string> EnviromentURL(string Env)
        {
            Parse LeerJson = new Parse();
            object Empty;
            string filelocationURL = LeerJson.FindFiles("*Urls.json");
            Empty = LeerJson.FileRequest(filelocationURL, "file");
            var fileURL = (DirectoryofURL)Empty;
            List<string> baseadress = new List<string>();

            switch (Env)
            {
                case "PRE":
                    baseadress.Add(fileURL.URL[0].DoAirPrice);
                    baseadress.Add(fileURL.URL[0].DoAirPriceFee);
                    baseadress.Add(fileURL.URL[0].DoBooking);
                    break;
                case "INT":
                    baseadress.Add(fileURL.URL[1].DoAirPrice);
                    baseadress.Add(fileURL.URL[1].DoAirPriceFee);
                    baseadress.Add(fileURL.URL[1].DoBooking);
                    break;
                case "PRO":
                    baseadress.Add(fileURL.URL[2].DoAirPrice);
                    baseadress.Add(fileURL.URL[2].DoAirPriceFee);
                    baseadress.Add(fileURL.URL[2].DoBooking);
                    break;
            }

            return baseadress;
        }

        public static ILog log(string Env, string ApplicationID)
        {
            Parse LeerJson = new Parse();
            string configfile = LeerJson.FindFiles("*log4net.xml");
            var whatever = LeerJson.LoadLog4netXmlDocument(configfile, Env, ApplicationID).DocumentElement;            
            XmlConfigurator.Configure(whatever);
            ILog log = LogManager.GetLogger(ApplicationID);
            return log;
        }


    }
}
