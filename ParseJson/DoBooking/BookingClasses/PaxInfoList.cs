
using System;
using System.Collections.Generic;


namespace ParseJson.DoBooking.BookingClasses
{
  
    public class PaxInfoList
    {

        public int Number { get; set; } 
        public string PaxType { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public Infant Infant { get; set; }
        public object PaxAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        public List<PassengerFee> PassengerFees { get; set; }
        public object InfoResidentData { get; set; }
        public string Gender { get; set; }
        public List<object> TravelDocument { get; set; }
        public bool isFrequent { get; set; }
        public object frequentOrder { get; set; }
        public bool saveAsFrequent { get; set; }

        public static implicit operator List<object>(PaxInfoList v)
        {
            throw new NotImplementedException();
        }


    }
}
/*
public class PaxInfoList
{
    public int Number { get; set; }
    public string PaxType { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public string Gender { get; set; }
    public object Infant { get; set; }
    public object PaxAddress { get; set; }
    public List<object> TravelDocument { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public object LastName2 { get; set; }
    public List<PassengerFee> PassengerFees { get; set; }
    public object InfoResidentData { get; set; }
}
*/