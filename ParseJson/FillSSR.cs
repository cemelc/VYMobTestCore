using System.Collections.Generic;
using ParseJson.DoAirPriceFee.DoAirPriceClasses;
using ParseJson.DoBooking.BookingClasses;
using ParseJson.DoAirPrice;


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
    }
}
