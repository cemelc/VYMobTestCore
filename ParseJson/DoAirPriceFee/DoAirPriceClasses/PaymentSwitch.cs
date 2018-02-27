

namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class PaymentSwitch
    {
        public bool IsCredit { get; set; }
        public decimal DebitValue { get; set; }
        public bool Hide { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CreditValue { get; set; }
    }
}
