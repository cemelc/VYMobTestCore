using ParseJson.DoAirPrice;
using ParseJson.Data;
using Newtonsoft.Json;
using System;

namespace ParseJson
{
    public class DataFillerObject
    {
        public DoAirPriceRequest DataDoAirPrice(int testcaseID)
        {

            Parse filereader = new Parse();
            string filelocation = filereader.FindFiles("*Data.json");
            object Empty = filereader.FileRequest(filelocation, "Data");
            var Dataobj = (TestData)Empty;
            DoAirPriceRequest doairpriceobject=null;
            DateTime Date;
            DateTime DateRe;
            switch (testcaseID)
            {
                case 1002:
                    Date = DateTime.Now.AddDays(-7);
                    DateRe = DateTime.Now.AddDays(10);
                    break;
                case 1003:
                    Date = DateTime.Now.AddDays(7);
                    DateRe = DateTime.Now.AddDays(4);
                    break;
                case 1008:
                    Date = DateTime.Now;
                    while (Date.DayOfWeek != DayOfWeek.Wednesday)
                    {
                        Date = Date.AddDays(+1);
                    }
                    DateRe = Date.AddDays(+1);
                    break;
                default:
                    Date = DateTime.Now.AddDays(7);
                    DateRe = DateTime.Now.AddDays(10);
                    break;
            }           
            
            

            foreach (var item in Dataobj.TestCases)
            {
                if (item.ID == testcaseID)
                {

                    doairpriceobject = new DoAirPriceRequest()
                    {
                        Paxs = item.Paxs,
                        AirportDateTimeList = item.AirportDateTimeList,
                        Language = item.Language,
                        DiscountType = item.DiscountType,
                        AppVersion = item.AppVersion,
                        DeviceType = item.DeviceType,
                        CurrencyCode= item.CurrencyCode,
                        PromoCode= item.PromoCode

                    };

                    if (item.AirportDateTimeList.Count == 2)
                    {
                        item.AirportDateTimeList[0].MarketDateDeparture = Date;
                        item.AirportDateTimeList[1].MarketDateDeparture = DateRe;
                    }
                    else {
                        item.AirportDateTimeList[0].MarketDateDeparture = Date;
                    }

                }
            }

            return doairpriceobject;
        }

        public object deserialize(Type anyhow, string response) {

            Type gethetype = anyhow.GetType();
            var oh = JsonConvert.DeserializeObject(response, anyhow);
            //DoAirPriceAndFeeResponseObjecto = JsonConvert.DeserializeObject<DoAirPriceFeeResponse>(Doairpricefeeresponsestring);
            return oh;
        }
    }
}
