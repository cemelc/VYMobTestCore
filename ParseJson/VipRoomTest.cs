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
    public class VipRoomTest
    {
        public const string ApplicationID = "Vueling.VipRoom";
       

        [TestMethod]
        public void VipRoom()
        {
            //Variables
            string Env = "PRE";
            var Date = DateTime.Now.AddDays(7);
            var DateRe = DateTime.Now.AddDays(10);
            string doairpriceresponsestring = null, Doairpricefeeresponsestring = null, dobookingresponsestring = null, baseAddressDoAirPrice = null,
                   baseAddressDoAirPriceAndFee = null, baseAddressDoBooking = null;

            //Objetos usados en codigo
            DoAirPriceRequest doairpricerequest;
            DoAirPriceResponse doAirPriceResponse;
            DoAirPriceFeeResponse DoAirPriceAndFeeResponseObjecto;
            DoAirPriceFeeRequest Doairpricefeerequest;
            DoBookingRequest BookingrequestObject;
            DobookingResponse BookingresponseObject;
            DirectoryofURL fileURL;
            Contacts Contact = new Contacts();
            List<Journey> currentJourney = new List<Journey>();
            SearchFlight flightsearch = new SearchFlight();
            object Empty;
            FillSSR ssrcode = new FillSSR();            
            Parse LeerJson = new Parse();

            //Buscar archivos para la prueba
            string configfile = LeerJson.FindFiles("*log4net.xml");
            var whatever = LeerJson.LoadLog4netXmlDocument(configfile, Env, ApplicationID).DocumentElement;
            Console.WriteLine(whatever);
            XmlConfigurator.Configure(whatever);
            var log = LogManager.GetLogger(ApplicationID);

            //Initcializar los logs
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));

            //DoAirPrice
            string filelocationDoAirPrice = LeerJson.FindFiles("*DoAirPrice.json");

            //DoPriceFee
            string filelocationDoAirPriceFee = LeerJson.FindFiles("*DoPriceAndFee.json");

            //DoBooking
            string filelocationDoBooking = LeerJson.FindFiles("*DoBooking.json");

            //Objeto de envio y recepcción
            SendFile envio = new SendFile();
            

            //Busqueda de endpoints
            string filelocationURL = LeerJson.FindFiles("*Urls.json");
            Empty = LeerJson.FileRequest(filelocationURL, "file");
            fileURL = (DirectoryofURL)Empty;
            Empty = null;

            //URls
            switch (Env)
            {
                case "PRE":
                    baseAddressDoAirPrice = fileURL.URL[0].DoAirPrice;
                    baseAddressDoAirPriceAndFee = fileURL.URL[0].DoAirPriceFee;
                    baseAddressDoBooking = fileURL.URL[0].DoBooking;
                    break;
                case "INT":
                    baseAddressDoAirPrice = fileURL.URL[1].DoAirPrice;
                    baseAddressDoAirPriceAndFee = fileURL.URL[1].DoAirPriceFee;
                    baseAddressDoBooking = fileURL.URL[1].DoBooking;
                    break;
                case "PRO":
                    baseAddressDoAirPrice = fileURL.URL[3].DoAirPrice;
                    baseAddressDoAirPriceAndFee = fileURL.URL[3].DoAirPriceFee;
                    baseAddressDoBooking = fileURL.URL[3].DoBooking;
                    break;
            }

            //Creación del objeto de request doairprice
            Empty = LeerJson.FileRequest(filelocationDoAirPrice, "DoAirPrice");
            doairpricerequest = (DoAirPriceRequest)Empty;
            doairpricerequest.AirportDateTimeList[0].MarketDateDeparture = Date;

            if (doairpricerequest.AirportDateTimeList.Count >= 2)
            {
                doairpricerequest.AirportDateTimeList[1].MarketDateDeparture = DateRe;
            }

            Empty = null;

            //Recepcción del request de do air price response
            bool retry3 = false;

            while (retry3 == false)
            {

                if (doairpriceresponsestring == null)
                {
                    doairpriceresponsestring = envio.SendFiles(baseAddressDoAirPrice, doairpricerequest);
                }
                else
                {
                    retry3 = true;
                }
            }


            doAirPriceResponse = JsonConvert.DeserializeObject<DoAirPriceResponse>(doairpriceresponsestring);

            //Selección del vuelo que usaremos para la pruebas
            currentJourney = flightsearch.FinddirFlight(doAirPriceResponse,"OP");
            log.Info("The journey picked is: " + currentJourney[0].JourneySellKey);
            log.Info("The fare picked is:" + currentJourney[0].JourneyFare[0].JourneyFareKey);

            if (currentJourney.Count >= 2)
            {
                log.Info("The journey picked is: " + currentJourney[1].JourneySellKey);
                log.Info("The fare picked is:" + currentJourney[1].JourneyFare[0].JourneyFareKey);
            }

            //DoPriceFee manipulación del objecto y envio de request
            Empty = LeerJson.FileRequest(filelocationDoAirPriceFee, "DoAirPriceFee");
            Doairpricefeerequest = (DoAirPriceFeeRequest)Empty;
            Empty = null;
            Doairpricefeerequest.SellKeyList[0].FareKey = currentJourney[0].JourneyFare[0].JourneyFareKey;
            Doairpricefeerequest.SellKeyList[0].JourneyKey = currentJourney[0].JourneySellKey;

            if (currentJourney.Count >= 2)
            {
                Doairpricefeerequest.SellKeyList.Add(new SellKeyList());
                Doairpricefeerequest.SellKeyList[1].FareKey = currentJourney[1].JourneyFare[0].JourneyFareKey;
                Doairpricefeerequest.SellKeyList[1].JourneyKey = currentJourney[1].JourneySellKey;
            }

            Doairpricefeerequest.PaxInfoList = doairpricerequest.Paxs;

            bool retry2 = false;

            while (retry2 == false)
            {

                if (Doairpricefeeresponsestring == null)
                {
                    Doairpricefeeresponsestring = envio.SendFiles(baseAddressDoAirPriceAndFee, Doairpricefeerequest);
                }
                else
                {
                    retry2 = true;
                }
            }

            //Llenado de objecto de respuesta del DoAirPRice
            DoAirPriceAndFeeResponseObjecto = JsonConvert.DeserializeObject<DoAirPriceFeeResponse>(Doairpricefeeresponsestring);
            Console.WriteLine("Resultado JourneySellKey del price and fee: " + DoAirPriceAndFeeResponseObjecto.Price.JourneysPrice[0].JourneySellKey);

            //Booking creación y manipulación del objeto
            Empty = LeerJson.FileRequest(filelocationDoBooking, "DoBooking");
            BookingrequestObject = (DoBookingRequest)Empty;
            Empty = null;

            //Llenar los campos necesarios para crear el request de booking
            BookingrequestObject.SellKeyList = Doairpricefeerequest.SellKeyList;


            BookingrequestObject.SellKeyList[0].PaxSSRList = ssrcode.FillingSSr(doairpricerequest).PaxSSRList;
            BookingrequestObject.JourneyList = currentJourney;
            //BookingrequestObject.segmentInfo.Add(currentJourney[0].Segments);


            //Paxinfolist
            var BookingrequestObjectaux = Contact.FillPaxInfo(doairpricerequest);
            BookingrequestObject.PaxInfoList = BookingrequestObjectaux.PaxInfoList;

            //BookingInfoList
            FillAncillaries AncillariesObject = new FillAncillaries();
            BookingrequestObject.BookingContact = Contact.FillContact(BookingrequestObject);
            BookingrequestObject.VipRoom = AncillariesObject.FillVipRoom(currentJourney, 1, DoAirPriceAndFeeResponseObjecto);


            //Choosing payment method
            PaymentMethod PaymentInfoObject = new PaymentMethod();
            BookingrequestObject.PaymentData = PaymentInfoObject.Payment("AE", Env); 
            //DoBookin              

            dobookingresponsestring = envio.SendFiles(baseAddressDoBooking, BookingrequestObject);
            //string json = JsonConvert.SerializeObject(BookingrequestObject, Formatting.Indented);


            BookingresponseObject = JsonConvert.DeserializeObject<DobookingResponse>(dobookingresponsestring);
            //Console.WriteLine("Response de Booking RecordLocator: " + BookingresponseObject.Success.RecordLocator);
            Console.WriteLine("Response de Booking RecordLocator: " + dobookingresponsestring);

            log.Info("The record Locator is: " + BookingresponseObject.Success.RecordLocator);


            log.Debug(string.Format("***** SERVICE FINALIZED: {0} *****", ApplicationID));
        }
    }

}


