using System.Linq;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoAirPrice;
using System.Collections.Generic;

namespace ParseJson
{
    public class BuscarVuelo
    {

        public List<Journey> FindconnFlight(DoAirPriceResponse flightselector, string type)
        {
            Journey firstBAonOutbound = new Journey();
            Journey firstBAonInbound = new Journey();
            var completeJourney = new List<Journey>();
            var fareList = new string[] { "BA", "OP", "EX" };

            firstBAonOutbound = flightselector.Trip.JourneyMarkets.First().Journeys.First(j => j.IsConnection  && fareList.Contains(j.JourneyFare.First().ProductClass));

            var notBAJourneyFareOutBound = firstBAonOutbound.JourneyFare.Where(jf => jf.ProductClass != type);


            foreach (var item in notBAJourneyFareOutBound.ToList())
            {
                firstBAonOutbound.JourneyFare.Remove(item);
            }

            completeJourney.Add(firstBAonOutbound);

            if (flightselector.Trip.JourneyMarkets.Count > 1)
            {
                firstBAonInbound = flightselector.Trip.JourneyMarkets.Last().Journeys.First(j => j.IsConnection && fareList.Contains(j.JourneyFare.First().ProductClass));
                var notBAJourneyFareInBound = firstBAonInbound.JourneyFare.Where(jf => jf.ProductClass != type);

                foreach (var item in notBAJourneyFareInBound.ToList())
                {
                    firstBAonInbound.JourneyFare.Remove(item);
                }                

                completeJourney.Add(firstBAonInbound);
            }
            return completeJourney;
        }

        public List<Journey> FinddirFlight(DoAirPriceResponse flightselector, string type)
        {
            Journey firstBAonOutbound = new Journey();
            Journey firstBAonInbound = new Journey();
            var completeJourney = new List<Journey>();
            var fareList = new string[] { "BA", "OP", "EX" };

            firstBAonOutbound = flightselector.Trip.JourneyMarkets.First().Journeys.First(j => j.IsConnection == false && fareList.Contains(j.JourneyFare.First().ProductClass));
            

            var notBAJourneyFareOutBound = firstBAonOutbound.JourneyFare.Where(jf => jf.ProductClass != type);


            foreach (var item in notBAJourneyFareOutBound.ToList())
            {
                firstBAonOutbound.JourneyFare.Remove(item);
            }

            completeJourney.Add(firstBAonOutbound);

            if (flightselector.Trip.JourneyMarkets.Count > 1)
            {
                firstBAonInbound = flightselector.Trip.JourneyMarkets.Last().Journeys.First(j => j.IsConnection == false && fareList.Contains(j.JourneyFare.First().ProductClass));
                var notBAJourneyFareInBound = firstBAonInbound.JourneyFare.Where(jf => jf.ProductClass != type);

                foreach (var item in notBAJourneyFareInBound.ToList())
                {
                    firstBAonInbound.JourneyFare.Remove(item);
                }

                completeJourney.Add(firstBAonInbound);
            }

            return completeJourney;
        }

        public List<Journey> FindMixedFlight(DoAirPriceResponse flightselector, string type)
        {
            Journey firstBAonOutbound = new Journey();
            Journey firstBAonInbound = new Journey();
            var completeJourney = new List<Journey>();
            var fareList = new string[] { "BA", "OP", "EX" };

            firstBAonOutbound = flightselector.Trip.JourneyMarkets.First().Journeys.First(j => j.IsConnection == false && fareList.Contains(j.JourneyFare.First().ProductClass));

            var notBAJourneyFareOutBound = firstBAonOutbound.JourneyFare.Where(jf => jf.ProductClass != type);


            foreach (var item in notBAJourneyFareOutBound.ToList())
            {
                firstBAonOutbound.JourneyFare.Remove(item);
            }

            completeJourney.Add(firstBAonOutbound);

            if (flightselector.Trip.JourneyMarkets.Count > 1)
            {
                firstBAonInbound = flightselector.Trip.JourneyMarkets.Last().Journeys.First(j => j.IsConnection && fareList.Contains(j.JourneyFare.First().ProductClass));
                var notBAJourneyFareInBound = firstBAonInbound.JourneyFare.Where(jf => jf.ProductClass != type);

                foreach (var item in notBAJourneyFareInBound.ToList())
                {
                    firstBAonInbound.JourneyFare.Remove(item);
                }

                completeJourney.Add(firstBAonInbound);
            }

            return completeJourney;
        }

    }
}
