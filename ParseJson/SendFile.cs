using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ParseJson
{
    public class SendFile
    {
        public String SendArchivo(string baseAddress, object filerequest)
        {
            if (filerequest == null)
            {
                throw new ArgumentNullException(nameof(filerequest));
            }

            string response = null;
            int Tries=3;
            HttpWebRequest httpWebRequest = null;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(baseAddress);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Timeout = 10000;            

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(filerequest, Formatting.Indented);
                streamWriter.Write(json);
                Console.WriteLine(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                HttpWebResponse httpResponse = null;
                httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    response = result;
                } 
            }catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.Timeout || ex.Status == WebExceptionStatus.ConnectFailure) { 
                    if (--Tries == 0)
                    {
                        throw;
                    }
                SendArchivo(baseAddress, filerequest);
                }
            }

            return response;


        }
    }
}
