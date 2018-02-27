using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseJson.DoBooking.BookingClasses
{
    public class AddToCalendar
    {
        public bool Active { get; set; }
        public bool Hide { get; set; }
        public string ErrorDescription { get; set; }
        public string LinkUrl { get; set; }
        public int Action { get; set; }
        public List<object> ActionInfoData { get; set; }
        public string Label { get; set; }
        public string ButtonTitle { get; set; }
        public string HeaderTitle { get; set; }
        public bool IsNewLogoActive { get; set; }
    }
}
