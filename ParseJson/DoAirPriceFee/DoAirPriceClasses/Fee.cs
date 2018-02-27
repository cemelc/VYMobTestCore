using System.Collections.Generic;



namespace ParseJson.DoAirPriceFee.DoAirPriceClasses
{
    public class Fee
    {
        public List<BagFee> BagFees { get; set; }
        public List<SeatFee> SeatFees { get; set; }
        public List<PaymentCardFee> PaymentCardFees { get; set; }
        public List<PaymentAlternativeFee> PaymentAlternativeFees { get; set; }
        public List<VipRoomFee> VipRoomFees { get; set; }
        public List<ChangeFee> ChangeFees { get; set; }
        public List<InsuranceFee> InsuranceFees { get; set; }
    }
}
