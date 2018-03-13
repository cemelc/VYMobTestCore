

namespace ParseJson.DoBooking.BookingClasses
{
    public class ChangeInfo
    {
        public SeatAllowed SeatAllowed { get; set; }
        public FlightAllowed FlightAllowed { get; set; }
        public BagAllowed BagAllowed { get; set; }
        public CheckinAllowed CheckinAllowed { get; set; }
        public InsuranceAllowed InsuranceAllowed { get; set; }
        public PetAllowed PetAllowed { get; set; }
        public SpecialEquipment SpecialEquipment { get; set; }
        public Atv Atv { get; set; }
        public VipRoomResponse VipRoom { get; set; }
        public HotelsAndCars HotelsAndCars { get; set; }
        public AddToCalendar AddToCalendar { get; set; }
        public ProcliPaxes ProcliPaxes { get; set; }
        public Contingencies Contingencies { get; set; }
        public NotAllowedBooking NotAllowedBooking { get; set; }
        public InsuranceResponse Insurance { get; set; }
        public YaAccess YaAccess { get; set; }
    }
}
