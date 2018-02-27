
using System;
using System.Collections.Generic;
using ParseJson.DoBooking;
using ParseJson.DoBooking.BookingClasses;
using ParseJson.DoAirPrice;
using ParseJson.Login;
using ParseJson.Login.LoginClasses;

namespace ParseJson
{
    public class Contacts
    {


        int ADT, CHD, INF, Total, paxnumber, number, Totalaux = 0;

        public BookingContact FillContact(DoBookingRequest actualcontact)
        {
            Parse LeerJson = new Parse();
            BookingContact Contact = new BookingContact();
            Contact = actualcontact.BookingContact;
            Contact.FirstName = "Contact Aut Name " + LeerJson.StringGen(5, 2);
            Contact.LastName = "Contact Aut Apellido " + LeerJson.StringGen(5, 2);
            Contact.EmailAddress = "email.aut" + (LeerJson.StringGen(5, 1) + "@" + "gmail" + "." + "com");

            return Contact;
        }

        public DoBookingRequest FillPaxInfo(DoAirPriceRequest request)
        {
            List<PaxInfoList> Paxinfoaux = new List<PaxInfoList>();
            DoBookingRequest actualcontact = new DoBookingRequest();

            foreach (var item in request.Paxs)
            {
                switch (item.PaxType)
                {
                    case "ADT":
                        ADT = item.Quantity;
                        break;
                    case "CHD":
                        CHD = item.Quantity;
                        break;
                    case "INF":
                        INF = item.Quantity;
                        break;
                }

            }

            Total = ADT + CHD + INF;
            Totalaux = Total - INF;

            for (var i = 0; i < Total; i++)
            {
                if (ADT > 0 && INF == 0)
                {
                    Paxinfoaux.Add(FillerPax(number, "Adulto", paxnumber, Totalaux));
                    number++;
                    ADT--;
                }

                if (ADT > 0 && INF > 0)
                {
                    paxnumber++;
                    Paxinfoaux.Add(FillerPax(number, "Infant", paxnumber, Totalaux));
                    number++;
                    Totalaux++;
                    ADT--;
                    INF--;
                }

                if (CHD > 0 && ADT == 0)
                {
                    Paxinfoaux.Add(FillerPax(number, "Child", paxnumber, Totalaux));
                    number++;
                    CHD--;
                }
            }
            actualcontact.PaxInfoList = Paxinfoaux;
            return actualcontact;
        }

        public PaxInfoList FillerPax(int contador, string type, int paxcount, int last)
        {

            PaxInfoList fillingobject = new PaxInfoList();
            DateTime Date = new DateTime();
            Parse LeerJson = new Parse();

            fillingobject.Number = contador;
            fillingobject.PaxType = "ADT";
            fillingobject.Title = "Mr";
            fillingobject.FirstName = "Pasajero Aut Name " + LeerJson.StringGen(5, 2);
            fillingobject.LastName = "Pasajero Aut LastName " + LeerJson.StringGen(6, 2);
            fillingobject.Gender = "Male";
            fillingobject.isFrequent = false;
            fillingobject.frequentOrder = null;
            fillingobject.saveAsFrequent = false;
            fillingobject.TravelDocument = null;


            switch (type)
            {
                case "Child":
                    Date = DateTime.Now.AddYears(-4);
                    fillingobject.DOB = Date;
                    fillingobject.PaxType = "CHD";
                    break;

                case "Infant":
                    contador++;

                    fillingobject.Infant = new Infant()
                    {
                        Number = last,
                        PaxType = "INF",
                        PaxNumber = paxcount,
                        FirstName = "Bebe Aut Name" + LeerJson.StringGen(5, 2),
                        LastName = "Bebe Aut LastName" + LeerJson.StringGen(5, 2),
                        OrderView = 3,
                        Type = 4,
                        isFrequent = false,
                        saveAsFrequent = false,
                        Parent = 0,
                        HasDni = true,
                        DOB = DateTime.Now.AddDays(-14)
                    };
                    break;
            }

            return fillingobject;

        }

        public CreateNewAccount NewAccount()
        {

            Parse LeerJson = new Parse();
            CreateNewAccount newUser = new CreateNewAccount();
            newUser.SecurityQuestions = new List<SecurityQuestion>();           

            newUser.DeviceType = "WEB";
            newUser.Language = "es-ES";
            newUser.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.167 Safari/537.36";
            newUser.TokenID = "75e3d859-024d-4ff4-ade2-48c9f3b6f020";
            newUser.Udid = "\"6979-5271-f146-5b16-421f-d63c\"";
            newUser.IP = "235.231.34.152";
            newUser.AirportOrigin = "BCN";
            newUser.Name = "Pasajero Aut Name " + LeerJson.StringGen(5, 2);
            newUser.LastName = "Pasajero Aut LastName " + LeerJson.StringGen(6, 2);
            newUser.Password = "Au!" + LeerJson.StringGen(6, 3);
            newUser.SubscribeToNewsletter = false;
            newUser.Email = "email.aut" + (LeerJson.StringGen(5, 1) + "@" + "gmail" + "." + "com");
            newUser.SecurityQuestions.Add(Security("2"));            
            newUser.SecurityQuestions.Add(Security("3"));


            return newUser;
        }


        public SecurityQuestion Security(string type)
        {

            Parse LeerJson = new Parse();           
            SecurityQuestion security = new SecurityQuestion();

            security.QuestionId = type;
            security.Answer = LeerJson.StringGen(5, 2);           

            return security;
        }
    }

}





