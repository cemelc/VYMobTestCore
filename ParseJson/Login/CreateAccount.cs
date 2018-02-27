using ParseJson.Login.LoginClasses;
using System.Collections.Generic;


namespace ParseJson.Login
{
    public class CreateNewAccount
    {
        public string DeviceType { get; set; }
        public string Language { get; set; }
        public string UserAgent { get; set; }
        public string TokenID { get; set; }
        public string Udid { get; set; }
        public string IP { get; set; }
        public string AirportOrigin { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public List<SecurityQuestion> SecurityQuestions { get; set; }
        public bool SubscribeToNewsletter { get; set; }
        public string Email { get; set; }

    }
}
