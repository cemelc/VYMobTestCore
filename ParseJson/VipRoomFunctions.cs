using System.Collections.Generic;
using System.Linq;
using ParseJson.DoAirPriceFee;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoBooking.BookingClasses;

namespace ParseJson
{
    public class VipRoomFunctions
    {

        public List<VipRoomRequest> FillVipRoom(List<Journey> currentjourney, int pasajeros, DoAirPriceFeeResponse doAirPriceFeeResponse)
        {
            List<VipRoomRequest> vipRooms = new List<VipRoomRequest>();
            VipRoomRequest AddVip = new VipRoomRequest();
            List<Segment> Segments = new List<Segment>();


            if (doAirPriceFeeResponse.Fee.VipRoomFees != null)
            {
                var segments = currentjourney.SelectMany(j => j.Segments);

                foreach (var segment in segments)
                { 
                    var vipRoomSegment = doAirPriceFeeResponse.Fee.VipRoomFees.Where(vr => vr.SegmentSellKey == segment.SegmentSellKey).FirstOrDefault();
                
                    AddVip = new VipRoomRequest()
                    {
                        SegmentSellKey = vipRoomSegment.SegmentSellKey,
                        StationCode = vipRoomSegment.StationCode,
                        code = vipRoomSegment.Code,                                                
                        PassengerNumbers = fillVippassanger(pasajeros)
                    };
                    vipRooms.Add(AddVip);
                }

            }

          
            return vipRooms;
        }

        private List<int> fillVippassanger(int pasajeros)
        {
            List<int> passangerlist = new List<int>();
            passangerlist.AddRange(Enumerable.Range(0, pasajeros));

            return passangerlist;
        }
    }
}
