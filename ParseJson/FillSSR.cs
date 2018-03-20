using System.Collections.Generic;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoBooking.BookingClasses;
using ParseJson.DoAirPrice;
using System.Linq;
using ParseJson.DoAirPriceFee;


namespace ParseJson
{
    public class FillSSR
    {
        public SellKeyList FillingSSr(DoAirPriceRequest request)
        {
            SellKeyList Sellkey = new SellKeyList();
            Sellkey.PaxSSRList = new List<PaxSSRList>();
            PaxSSRList paxinfo = new PaxSSRList();

            int INF = 0;

            foreach (var item in request.Paxs)
            {
                switch (item.PaxType)
                {
                    case "INF":
                        INF = item.Quantity;
                        break;
                }

            }

            for (int i = 0; i < INF; i++)
            {
                paxinfo = PaxCreation("INFT", i);
                Sellkey.PaxSSRList.Add(paxinfo);

            }

            return Sellkey;
        }

        public PaxSSRList PaxCreation(string type, int number)
        {

            PaxSSRList paxinfoaux = new PaxSSRList();

            switch (type)
            {
                case "INFT":
                    paxinfoaux.PassengerNumber = number;
                    paxinfoaux.SSRCode = "INFT";
                    break;
                case "BAG1":
                    paxinfoaux.PassengerNumber = number;
                    paxinfoaux.SSRCode = "INFT";
                    break;
                case "BAG2":
                    paxinfoaux.PassengerNumber = number;
                    paxinfoaux.SSRCode = "BAG2";
                    break;
                case "BAG3":
                    paxinfoaux.PassengerNumber = number;
                    paxinfoaux.SSRCode = "BAG3";
                    break;

            }
            return paxinfoaux;
        }

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
