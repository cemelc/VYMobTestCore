using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseJson.DoAirPrice.DoAirPriceClasses
{

    public class Error
    {
        public Error() {
            ValidationResult = new List<ValidationResult>();
        }

        public bool IsApiError { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }
        public object InternalErrorMessage { get; set; }
        public List<ValidationResult> ValidationResult { get; set; }
        public bool Popup { get; set; }
        public bool Block { get; set; }
    }

}
