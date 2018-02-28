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
        public const string Env = "PRE";
        //private static ILog log = LogManager.GetLogger(ApplicationID);

        [TestMethod]
        public void LoginExisting()
        {
            FileManager Fileobject = new FileManager();
            string configfile = Fileobject.FindFiles("*log4net.xml");         
            XmlConfigurator.Configure(Fileobject.LoadLog4netXmlDocument(configfile, Env, ApplicationID).DocumentElement);
            var log = LogManager.GetLogger(ApplicationID);
            
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));

            LoginRequest loginReqObj = new LoginRequest() {
                Username = "email.auts7g3s@gmail.com",
                Password = "Au!591850",
                IP = "235.231.34.152",
                DeviceType = "WEB",
                Language = "es-ES",
                TokenID = "1f2df8d2-484d-4988-8dde-5d03e319520d",
                UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 64.0.3282.167 Safari / 537.36",
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
            string login = envio.SendArchivo(fileURL.URL[0].Login, loginReqObj);
            var loginObject = JsonConvert.DeserializeObject<LoginResponse>(login);


            log.Info("El mail del usuario es:" + loginObject.MemberData.Email);
            Console.WriteLine("El login esperado es:" + loginObject.MemberData.Email);
            log.Info("El nombre del usuario es:" + loginObject.MemberData.FirstName);
            Console.WriteLine("El login esperado es:" + loginObject.MemberData.FirstName);





        }
    }

}
