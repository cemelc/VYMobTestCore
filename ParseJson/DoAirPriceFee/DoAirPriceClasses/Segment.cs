
using System;
using System.Collections.Generic;
using ParseJson.DoBooking.BookingClasses;

namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class Segment
    {
        public bool IsInternational { get; set; }
        public string SegmentSellKey { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime STD { get; set; }
        public DateTime STA { get; set; }
        public int Duration { get; set; }
        public string CarrierCode { get; set; }
        public string FlightNumber { get; set; }
        public bool ArriveNextDay { get; set; }
        public List<object> Paxs { get; set; }
        public List<Fare> Fares { get; set; }        
        public int ArrvLTV { get; set; }
        public int DeptLTV { get; set; }
        public string OperatedBy { get; set; }
        public OperatedByIcon OperatedByIcon { get; set; }
       
    }

}



