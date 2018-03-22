using System.Collections.Generic;
using System.Linq;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoBooking.BookingClasses;
using ParseJson.DoAirPriceFee;


namespace ParseJson
{
    class FillAncillaries
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

        public List<InsuranceRequest> FillInsurance(List<Journey> currentjourney, int pasajeros, DoAirPriceFeeResponse doAirPriceFeeResponse, int Type)
        {
            List<InsuranceRequest> insurancelot = new List<InsuranceRequest>();
            IEnumerable<InsuranceRequest> auxinsurelot;

            var date = (currentjourney[0].STD - currentjourney[1].STD).TotalDays;
            InsuranceRequest insurance;
           

            foreach (var item in doAirPriceFeeResponse.Fee.InsuranceFees)
            {
                insurance = new InsuranceRequest()
                {
                    code = item.Code,
                    passengerNumbers = fillVippassanger(pasajeros)
                };
                insurancelot.Add(insurance);
            }
            
            switch (Type)
            {
                case 1:
                    auxinsurelot = insurancelot.Where(j => j.code != "SAS"); //Lost
                    break;
                case 2:
                    auxinsurelot = insurancelot.Where(j => j.code != "SEA"); //Nulled
                    break;
                case 3:
                    auxinsurelot = insurancelot.Where(j => j.code != "SEM"); //Medic
                    break;
                default:
                    auxinsurelot = insurancelot;//All
                    break;
            }
            if (Type != 4)
            {
                foreach (var item in auxinsurelot.ToList())
                {
                    insurancelot.Remove(item);
                }
            }           

            return insurancelot;
        }

        private List<int> fillVippassanger(int pasajeros)
        {
            List<int> passangerlist = new List<int>();
            passangerlist.AddRange(Enumerable.Range(0, pasajeros));

            return passangerlist;
        }
    }
}
