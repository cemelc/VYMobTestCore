using System.Linq;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoAirPrice;

namespace ParseJson
{
    public class BuscarVuelo
    {

        public Journey FindconnFlight(DoAirPriceResponse flightselector)
        {
            Journey firstBAonOutbound;

            firstBAonOutbound = flightselector.Trip.JourneyMarkets.First().Journeys.First(j => j.IsConnection && j.JourneyFare.First().ProductClass == "BA");

            var notBAJourneyFare = firstBAonOutbound.JourneyFare.Where(jf => jf.ProductClass != "BA");


            foreach (var item in notBAJourneyFare.ToList())
            {
                firstBAonOutbound.JourneyFare.Remove(item);
            }


            if (flightselector.Trip.JourneyMarkets.Count > 1)
            {
                var firstBAonInbound = flightselector.Trip.JourneyMarkets.Last().Journeys.First(j => j.IsConnection && j.JourneyFare.First().ProductClass == "BA");
            }
            return firstBAonOutbound;
        }

        public Journey FinddirFlight(DoAirPriceResponse flightselector)
        {
            Journey firstBAonOutbound;
            firstBAonOutbound = flightselector.Trip.JourneyMarkets.First().Journeys.First(j => j.IsConnection == false && j.JourneyFare.First().ProductClass == "BA");

            if (flightselector.Trip.JourneyMarkets.Count > 1)
            {
                var firstBAonInbound = flightselector.Trip.JourneyMarkets.Last().Journeys.First(j => j.IsConnection == false && j.JourneyFare.First().ProductClass == "BA");
            }
            return firstBAonOutbound;
        }
    }
}
