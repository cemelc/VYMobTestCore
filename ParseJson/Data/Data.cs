using System.Collections.Generic;
using ParseJson.DoAirPrice.DoAirPriceClasses;

namespace ParseJson.Data
{
    class Data
    {
        public class TestCas
        {
            public int ID { get; set; }
            public string CurrencyCode { get; set; }
            public string AppVersion { get; set; }
            public string DeviceType { get; set; }
            public string Language { get; set; }
            public int DiscountType { get; set; }
            public int PaxNumber { get; set; }
            public string VipRooms { get; set; }
            public List<Pax> Paxs { get; set; }
            public List<AirportDateTimeList> AirportDateTimeList { get; set; }
        }

        public class RootObject
        {
            public List<TestCas> TestCases { get; set; }
        }
    }
}
