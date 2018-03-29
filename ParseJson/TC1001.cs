using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseJson.DoAirPrice;
using ParseJson.DoAirPrice.DoAirPriceClasses;
using System.Collections.Generic;
using System.Linq;

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


            int testID = 1001;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            var doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);

            DoAirPriceResponse doairpriceresponseobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpriceresponseobject.GetType(), doairpriceresponse);

            doairpriceresponseobject = (DoAirPriceResponse)genericobject;

            if (doairpriceresponseobject.Trip.JourneyMarkets.Count >= 0)
            {
                log.Error("Para vuelos internacionales el sistema no deberia devolver un listado de vuelos con descuentos residentes");
            }
            else
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));

        }

        [TestMethod]
        public void TesTcase1002()
        {
            int testID = 1002;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            var doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);
            Console.WriteLine("Response: " + doairpriceresponse);
            DoAirPriceResponse doairpriceresponseobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpriceresponseobject.GetType(), doairpriceresponse);


            doairpriceresponseobject = (DoAirPriceResponse)genericobject;

            if (doairpriceresponseobject.Error.Code.Contains("E_PRRQ_VAL"))
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente, el sistema no puede asignar fechas de salida menores a la actual");
            }
            else
            {
                log.Error("Se esperaba un error en fechas de llegada");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));
        }

        [TestMethod]
        public void TesTcase1003()
        {
            int testID = 1003;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            var doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);
            Console.WriteLine("Response: " + doairpriceresponse);
            DoAirPriceResponse doairpriceresponseobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpriceresponseobject.GetType(), doairpriceresponse);


            doairpriceresponseobject = (DoAirPriceResponse)genericobject;

            if (doairpriceresponseobject.Error.Code.Contains("E_PRRQ_VAL"))
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente, el sistema no puede asignar fechas de llegada menores a las de salida");
            }
            else
            {
                log.Error("Se esperaba un error en fechas  de salida");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));
        }

        [TestMethod]
        public void TesTcase1004()
        {
            int testID = 1004;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            var doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);
            Console.WriteLine("Response: " + doairpriceresponse);
            DoAirPriceResponse doairpriceresponseobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpriceresponseobject.GetType(), doairpriceresponse);


            doairpriceresponseobject = (DoAirPriceResponse)genericobject;

            if (doairpriceresponseobject.Trip.JourneyMarkets.Count == 1)
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente, El sistema autocompleta la currency cuando es Euros");
            }
            else
            {
                log.Error("Se esperaba un error en fechas  de salida");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));
        }

        [TestMethod]
        public void TesTcase1005()
        {
            int testID = 1005;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            var doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);
            Console.WriteLine("Response: " + doairpriceresponse);
            DoAirPriceResponse doairpricerequestobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpricerequestobject.GetType(), doairpriceresponse);


            doairpricerequestobject = (DoAirPriceResponse)genericobject;

            if (doairpricerequestobject.Error.Code.Contains("E_PROMOVY_"))
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente, El sistema no acepta codigos invalidos");
            }
            else
            {
                log.Error("Se esperaba que el sistema invalidará el codigo promocional falso");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));
        }

        [TestMethod]
        public void TesTcase1006()
        {
            int testID = 1006;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            string doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);
            Console.WriteLine("Response: " + doairpriceresponse);
            DoAirPriceResponse doairpriceresponseobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpriceresponseobject.GetType(), doairpriceresponse);


            doairpriceresponseobject = (DoAirPriceResponse)genericobject;

            bool respuestaida = doairpriceresponseobject.Trip.JourneyMarkets.FirstOrDefault().Journeys.All(x => x.JourneyFare.All(ij => ij.IsPromoVYAplicable == true &&
                                                                                                                                    ij.IsFareAvailable == true));

            bool respuestavuelta = doairpriceresponseobject.Trip.JourneyMarkets.LastOrDefault().Journeys.All(x => x.JourneyFare.All(ij => ij.IsPromoVYAplicable == true &&
                                                                                                                                    ij.IsFareAvailable == true));

            if (respuestaida == true && respuestavuelta == true)
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente, El sistema esta devolviendo las promociones correctamente");
            }
            else
            {
                log.Error("Se esperaba que el sistema invalidará el codigo promocional falso");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));
        }

        [TestMethod]
        public void TesTcase1007()
        {
            int testID = 1007;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            var doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);
            Console.WriteLine("Response: " + doairpriceresponse);
            DoAirPriceResponse doairpriceresponseobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpriceresponseobject.GetType(), doairpriceresponse);


            doairpriceresponseobject = (DoAirPriceResponse)genericobject;


            var outboundDepartureStation = doairpicerequestobject.AirportDateTimeList.FirstOrDefault().DepartureStation;
            var outboundMarketDeparture = doairpicerequestobject.AirportDateTimeList.FirstOrDefault().MarketDateDeparture;
            var inboundDepartureStation = doairpicerequestobject.AirportDateTimeList.LastOrDefault().DepartureStation;
            var inboundMarketDateDeparture = doairpicerequestobject.AirportDateTimeList.LastOrDefault().MarketDateDeparture;


            var Stationsida = doairpriceresponseobject.Trip.JourneyMarkets[0].Journeys.All(x => x.DepartureStation == outboundDepartureStation &&
                                                                                            x.ArrivalStation == inboundDepartureStation);

            var Fechasida = doairpriceresponseobject.Trip.JourneyMarkets[0].Journeys.All(x => x.STA.Date == outboundMarketDeparture.Date &&
                                                                                          x.STD.Date == outboundMarketDeparture.Date &&
                                                                                          x.ArriveNextDay == false);

            var Stationsvuelta = doairpriceresponseobject.Trip.JourneyMarkets[1].Journeys.All(x => x.DepartureStation == outboundDepartureStation &&
                                                                                            x.ArrivalStation == inboundDepartureStation);

            var Fechasvuelta = doairpriceresponseobject.Trip.JourneyMarkets[1].Journeys.All(x => x.STA.Date == outboundMarketDeparture.Date &&
                                                                                          x.STD.Date == outboundMarketDeparture.Date &&
                                                                                          x.ArriveNextDay == false);


            if (doairpriceresponseobject.Trip.JourneyMarkets.Count >= 2)
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente, esta devolviendo bien los journey en el DoAirPrice");
            }
            else
            {
                log.Error("Se esperaba que el sistema invalidará el codigo promocional falso");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));
        }


        [TestMethod]
        public void TesTcase1008()
        {
            int testID = 1008;

            var log = RandomGenerator.log(Env, ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));
            log.Info(string.Format("TestCase:  " + testID));

            List<string> EnviromentsURLs = RandomGenerator.EnviromentURL(Env);

            DataFillerObject DataObject = new DataFillerObject();
            DoAirPriceRequest doairpicerequestobject = DataObject.DataDoAirPrice(testID);

            SendFile SendObject = new SendFile();
            var doairpriceresponse = SendObject.SendFiles(EnviromentsURLs[0], doairpicerequestobject);
            Console.WriteLine("Response: " + doairpriceresponse);
            DoAirPriceResponse doairpriceresponseobject = new DoAirPriceResponse();

            var genericobject = DataObject.deserialize(doairpriceresponseobject.GetType(), doairpriceresponse);

            doairpriceresponseobject = (DoAirPriceResponse)genericobject;

            if (doairpriceresponseobject.Trip.DiscountType == 4 && doairpriceresponseobject.Trip.JourneyMarkets.Count >= 1)
            {
                log.Info("La prueba " + testID + " ha finalizado exitosamente,Se Eencuentra el descuento residente familiar para la ruta especificada");
            }
            else
            {
                log.Error("Se esperaba que el sistema invalidará el codigo promocional falso");
            }

            log.Debug(string.Format("***** Prueba " + testID + "Finalizada *****"));
        }
    }
}
