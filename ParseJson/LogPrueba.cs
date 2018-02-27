using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net.Config;
using log4net;

namespace ParseJson
{

    [TestClass]
    public class Loggin
    {
        public const string ApplicationID = "Vueling.Loggin";
        public const string Env = "PRE";
        //private static ILog log = LogManager.GetLogger(ApplicationID);

        [TestMethod]
        public void LogginExisting()
        {
            FileManager Fileobject = new FileManager();
            string configfile = Fileobject.FindFiles("*log4net.xml");         
            XmlConfigurator.Configure(Fileobject.LoadLog4netXmlDocument(configfile, Env, ApplicationID).DocumentElement);
            var log = LogManager.GetLogger(ApplicationID);
            




        }
    }

}
