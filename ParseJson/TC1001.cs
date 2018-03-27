using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net;
using Newtonsoft.Json;
using log4net.Config;
using ParseJson.DoAirPriceFee;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoBooking;
using ParseJson.DoAirPrice;
using System.Collections.Generic;

namespace ParseJson
{

    [TestClass]
    public class Tesplan
    {
        public static string ApplicationID = "Vueling.TestcasesPrueba";
        public static string Env = "PRE";

        [TestMethod]
        public void TesTCase1001()
        {
            
            var Date = DateTime.Now.AddDays(7);
            var DateRe = DateTime.Now.AddDays(10);
            
            var log = RandomGenerator.log(Env,ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));

            List<string> EnviromentsURLs =  RandomGenerator.EnviromentURL(Env);

            DoAirPriceRequest doairpicerequestobject = 



        }
        [TestMethod]
        public void TesTcase1002()
        {

        }

    }
}
