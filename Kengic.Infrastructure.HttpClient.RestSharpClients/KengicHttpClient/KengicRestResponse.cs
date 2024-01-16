using System.Net;

namespace WasWebServerCore.Kengic.Infrastructure.HttpClient.RestSharpClients.KengicHttpClient
{
    public class KengicRestResponse

    {
        public HttpStatusCode Code { get; set; }
        public string Body { get; set; }
    }

}
