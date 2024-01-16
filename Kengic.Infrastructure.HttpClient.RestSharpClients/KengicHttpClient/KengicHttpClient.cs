using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using RestSharp;

namespace WasWebServerCore.Kengic.Infrastructure.HttpClient.RestSharpClients.KengicHttpClient
{
    public class KengicHttpClient
    {
        private string _ip;
        private string _port;
        private string _interfaceName;
        private string _url;

        public KengicHttpClient(string ip, string port)// partRoute= "/kengic/" 
        {
            _ip = ip;
            _port = port;
        }

        public async Task AsyncPostJsonMessage(string partRoute, string interfaceName, object messageToSent)
        {
            _interfaceName = interfaceName;
            _url = "http://" + _ip + ":" + _port + partRoute + _interfaceName;
            var restSharpClient = new RestSharpClient.RestSharpClient(_url, null);
            RestRequest request = new RestRequest(Method.POST);
            var message = JsonConvert.SerializeObject(messageToSent);
            request.AddParameter("application/json; charset=utf-8", message, ParameterType.RequestBody);
            //restSharpClient.Execute(request);
            restSharpClient.ExecuteAsync  (request, Callback);
        }

        public async Task<string> PostXmlMessage(string partRoute, string interfaceName, string messageToSent)
        {
            try
            {
                _interfaceName = interfaceName;
                _url = "http://" + _ip + ":" + _port + partRoute + _interfaceName;
                var restSharpClient = new RestSharpClient.RestSharpClient(_url, null);
                RestRequest request = new RestRequest(Method.POST);
                //var json = new NewtonsoftJsonSerializationAndDeserialization();
                //var message = XmlSerializer(messageToSent).Replace("<delete>", "").Replace("</delete>", "").Replace("\r\n","");
                //var message = XmlSerializer(messageToSent).Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");
                request.AddParameter("application/xml; charset=utf-8", messageToSent, ParameterType.RequestBody);
                var response = restSharpClient.Execute(request);
                return response.Content;
                //restSharpClient.ExecuteAsync(request, Callback);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public string XmlSerializer(object obj)
        {
            try
            {
                StringWriter sw = new StringWriter();
                XmlSerializer xz = new XmlSerializer(obj.GetType());
                using (MemoryStream ms = new MemoryStream())
                {
                    xz.Serialize(ms, obj);
                    var result = Encoding.UTF8.GetString(ms.ToArray());
                    return result;
                }
                //StringWriter sw = new StringWriter();
                //XmlSerializer xz = new XmlSerializer(obj.GetType());
                //xz.Serialize(sw, obj);
                //return sw.ToString();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void Callback(IRestResponse obj)
        {

            var kengicRestResponse = new KengicRestResponse()
            {
                Code = obj.StatusCode,
                Body = obj.Content
            };
            if (OnMessageReplyed != null)
            {

                OnMessageReplyed?.Invoke(this, kengicRestResponse);
            }
        }
        public event HttpClientEventHandler<KengicRestResponse> OnMessageReplyed;
    }
    public delegate Task HttpClientEventHandler<in T>(object source, T e);
}
