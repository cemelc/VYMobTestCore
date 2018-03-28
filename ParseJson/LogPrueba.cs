using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net.Config;
using log4net;
using ParseJson.Login;
using System;
using Newtonsoft.Json;

namespace ParseJson
{

    [TestClass]
    public class LoginTest
    {
        public const string ApplicationID = "Vueling.Login";        
        //private static ILog log = LogManager.GetLogger(ApplicationID);

        [TestMethod]
        public void LoginExisting()
        {
            string Env = "PRE";
            Parse Fileobject = new Parse();
            string configfile = Fileobject.FindFiles("*log4net.xml");         
            XmlConfigurator.Configure(Fileobject.LoadLog4netXmlDocument(configfile, Env, ApplicationID).DocumentElement);
            var log = LogManager.GetLogger(ApplicationID);
            
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));

            LoginRequest loginReqObj = new LoginRequest() {
                Username = "email.autJCFF1@gmail.com",
                Password = "Au!506581",
                IP = "235.231.34."+RandomGenerator.RandomString(3,3),
                DeviceType = "WEB",
                Language = "es-ES",
                TokenID = RandomGenerator.RandomString(6, 3),                
                Udid = "\"6979-5271-f146-5b16-421f-d63c\""
            };

            Parse LeerJson = new Parse();
            DirectoryofURL fileURL;
            Object Empty;
            SendFile envio = new SendFile();
            string filelocationURL = Fileobject.FindFiles("*Urls.json");
            Empty = LeerJson.FileRequest(filelocationURL, "file");
            fileURL = (DirectoryofURL)Empty;           


            var urlocation = Fileobject.FindFiles("*Urls.json");
            DirectoryofURL URlobject = (DirectoryofURL)LeerJson.FileRequest(urlocation, "file");


            bool retry = false;
            string login = null;
            int i = 0;

            while (retry == false)
            {
                if (login == null || login.Contains("E_AVIOS") || login.Contains("E_SYSTEM"))
                {
                    login = envio.SendFiles(fileURL.URL[0].Login, loginReqObj);
                    if (i == 10)
                    {
                        retry = true;
                    }
                    i++;

                }
                else
                {
                    retry = true;
                }
            }

            var loginObject = JsonConvert.DeserializeObject<LoginResponse>(login);

            log.Info("El mail del usuario es:" + loginObject.MemberData.Email);
            Console.WriteLine("El login esperado es:" + loginObject.MemberData.Email);
            log.Info("El nombre del usuario es:" + loginObject.MemberData.FirstName);
            Console.WriteLine("El login esperado es:" + loginObject.MemberData.FirstName);
        }
    }

}
