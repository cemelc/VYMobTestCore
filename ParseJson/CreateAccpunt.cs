using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net.Config;
using log4net;
using ParseJson.Login;
using System;

namespace ParseJson
{

    [TestClass]
    public class CreateAccount
    {
        public const string ApplicationID = "Vueling.CreateAccount";
        public const string Env = "PRE";

        [TestMethod]
        public void CreateAccountTest()
        {
            FileManager Fileobject = new FileManager();
            string configfile = Fileobject.FindFiles("*log4net.xml");
            XmlConfigurator.Configure(Fileobject.LoadLog4netXmlDocument(configfile, Env, ApplicationID).DocumentElement);
            var log = LogManager.GetLogger(ApplicationID);
            log.Debug(string.Format("***** SERVICE INITIALIZED: {0} *****", ApplicationID));

            SendFile envio = new SendFile();
            Parse LeerJson = new Parse();

            var urlocation = Fileobject.FindFiles("*Urls.json");
            DirectoryofURL URlobject = (DirectoryofURL)LeerJson.FileRequest(urlocation, "file");

            CreateNewAccount register = new CreateNewAccount();
            Contacts contacto = new Contacts();
            register = contacto.NewAccount();

            string idusuario = envio.SendArchivo(URlobject.URL[0].CreateAccount, register);
            log.Info("The User ID created is: " + idusuario);
            Console.WriteLine("ID es:" + idusuario);

            log.Debug(string.Format("***** SERVICE FINALIZED: {0} *****", ApplicationID));
        }
    }

}
