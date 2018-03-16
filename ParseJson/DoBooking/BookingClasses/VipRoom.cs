
using System.Collections.Generic;


namespace ParseJson.DoBooking.BookingClasses
{
    public class VipRoomResponse
    {
        public bool Active { get; set; }
        public bool Hide { get; set; }
        public string ErrorDescription { get; set; }
        public string LinkUrl { get; set; }
        public int Action { get; set; }
        public List<object> ActionInfoData { get; set; }
        public string Label { get; set; }
        public string ButtonTitle { get; set; }
        public string HeaderTitle { get; set; }
        public bool IsNewLogoActive { get; set; }

    }


    public class VipRoomRequest
    {

        public VipRoomRequest()
        {

            PassengerNumbers = new List<int>();

        }

        public string StationCode { get; set; }
            public string SegmentSellKey { get; set; }
            public List<int> PassengerNumbers { get; set; }
            public string code { get; set; }
            public string VuelingID { get; set; }
            public string Name { get; set; }        
    }

}
