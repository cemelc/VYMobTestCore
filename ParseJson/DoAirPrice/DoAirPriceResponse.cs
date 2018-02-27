using ParseJson.DoAirPrice.DoAirPriceClasses;

namespace ParseJson.DoAirPrice
{
    public class DoAirPriceResponse
    {
        public Trip Trip { get; set; }
        public string Signature { get; set; }
        public object Error { get; set; }
        public object Warning { get; set; }
        public object Warnings { get; set; }
    }
}
