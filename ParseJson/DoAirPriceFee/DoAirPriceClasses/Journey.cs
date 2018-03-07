
using System;
using System.Collections.Generic;
using ParseJson.DoBooking.BookingClasses;

namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class Journey
    {

        public Journey()
        {
            Segments = new List<Segment>();
            JourneyFare = new List<JourneyFare>();
            PriceClassMap = new List<PriceClassMap>();
        }

            public string JourneySellKey { get; set; }
            public string DepartureStation { get; set; }
            public string ArrivalStation { get; set; }
            public DateTime STA { get; set; }
            public DateTime STD { get; set; }
            public int Duration { get; set; }
            public bool IsConnection { get; set; }
            public bool ArriveNextDay { get; set; }
            public int ConnectionTime { get; set; }
            public bool isShortConnection { get; set; }
            public List<Segment> Segments { get; set; }
            public List<JourneyFare> JourneyFare { get; set; }
            public object AtvState { get; set; }
            public object AtvCode { get; set; }
            public int AtvTime { get; set; }
            public bool CheckinLostWarning { get; set; }
            public object State { get; set; }
            public string OperatedBy { get; set; }
            public List<OperatedByIcon> OperatedByIcons { get; set; }
            public List<PriceClassMap> PriceClassMap { get; set; }
            public HeaderIcon HeaderIcon { get; set; }
            public bool VyOperated { get; set; }
            public string DepartureTerminal { get; set; }
            public string GoverningFare { get; set; }
            public double Amount { get; set; }
    }

}
