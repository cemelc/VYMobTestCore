using System.Collections.Generic;
using ParseJson.DoBooking.BookingClasses;


namespace ParseJson.DoBooking
{
    
    public class DobookingResponse
    {
        public Success Success { get; set; }
        public ChangeInfo ChangeInfo { get; set; }
        public CheckinValidations CheckinValidations { get; set; }
        public List<object> VipRooms { get; set; }
        public List<object> Insurance { get; set; }
        public TrackingInventory TrackingInventory { get; set; }
        public string Signature { get; set; }
        public object Error { get; set; }
        public object Warning { get; set; }
        public List<Warning> Warnings { get; set; }
    }
}
