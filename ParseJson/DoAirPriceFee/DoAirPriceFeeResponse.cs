using ParseJson.DoAirPriceFee.DoAirPriceClasses;

namespace ParseJson.DoAirPriceFee
{
    public class DoAirPriceFeeResponse
    {
        public Fee Fee { get; set; }
        public Price Price { get; set; }
        public object BonoInfo { get; set; }
        public PaymentSwitch PaymentSwitch { get; set; }
        public string Signature { get; set; }
        public object Error { get; set; }
        public object Warning { get; set; }
        public object Warnings { get; set; }
    }
}
