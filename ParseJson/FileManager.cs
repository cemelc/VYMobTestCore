using System;
using System.IO;
using System.Xml;

namespace ParseJson
{
    public class FileManager
    {
        public String FindFiles(string filename)
        {
            string[] getfile;

            if (filename.Contains("xml") == true)
            {
                getfile = Directory.GetFiles(@".\", filename);
            }
            else
            {
                getfile = Directory.GetFiles(@".\Files", filename);
            }

            string filelocation = String.Join("", getfile);
            //log.Info("The file used is: " + filelocation);

            return filelocation;
        }


        public XmlDocument LoadLog4netXmlDocument(string path, string Environment, string ApplicationId)
        {

            if (string.IsNullOrEmpty(path))
                throw new Exception("Invalid log4net config path!!!");

            var xmlDoc = new XmlDocument();

            var xmlData = File.ReadAllText(path);


            xmlData = xmlData.Replace("{ApplicationId}", ApplicationId)
                         .Replace("{LogLevel}", "DEBUG")
                         .Replace("{Environment}", Environment);

            var xmlDataaux = xmlData;
            xmlDoc.LoadXml(xmlDataaux);
            return xmlDoc;

        }
    }
}
