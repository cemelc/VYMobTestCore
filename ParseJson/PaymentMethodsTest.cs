using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net.Config;
using log4net;
using ParseJson.Login;
using System;

namespace ParseJson
{

    [TestClass]
    public class PaymentMethodsTest
    {
        public const string ApplicationID = "Vueling.CreateAccount";
        public const string Env = "PRE";

        [TestMethod]
        public void PaymentMethod()
        {
            FileManager Fileobject = new FileManager();
            string configfile = Fileobject.FindFiles("*log4net.xml");
            XmlConfigurator.Configure(Fileobject.LoadLog4netXmlDocument(configfile, Env, ApplicationID).DocumentElement);
            var log = LogManager.GetLogger(ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));

            SendFile envio = new SendFile();
            Parse LeerJson = new Parse();

            var urlocation = Fileobject.FindFiles("*Urls.json");
            DirectoryofURL URlobject = (DirectoryofURL)LeerJson.FileRequest(urlocation, "file");

            string filelocationDoAirPrice = Fileobject.FindFiles("*DoAirPrice.json");

            //DoPriceFee
            string filelocationDoAirPriceFee = Fileobject.FindFiles("*DoPriceAndFee.json");

            //DoBooking
            string filelocationDoBooking = Fileobject.FindFiles("*DoBooking.json");


            log.Debug(string.Format("***** SERVICE FINALIZED: {0} *****", ApplicationID));
        }
    }

}
