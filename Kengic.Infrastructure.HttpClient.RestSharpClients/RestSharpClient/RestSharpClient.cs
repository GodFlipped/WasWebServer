using System;
using RestSharp;
using RestSharp.Authenticators;

namespace WasWebServerCore.Kengic.Infrastructure.HttpClient.RestSharpClients.RestSharpClient
{
    public class RestSharpClient : IRestSharp
    {
        private RestClient client;
        private string BaseUrl { get; set; }
        private string DefaultDateParameterFormat { get; set; }
        private IAuthenticator DefaultAuthenticator { get; set; }
        public RestSharpClient(string baseUrl, IAuthenticator authenticator = null)
        {
            BaseUrl = baseUrl;
            client = new RestClient(BaseUrl);
            DefaultAuthenticator = authenticator;
            DefaultDateParameterFormat = "yyyy-MM-dd HH:mm:ss";
            if (DefaultAuthenticator != null)
            {
                client.Authenticator = DefaultAuthenticator;
            }
        }
        public IRestResponse Execute(IRestRequest request)
        {
            request.DateFormat = string.IsNullOrEmpty(request.DateFormat) ? DefaultDateParameterFormat : request.DateFormat;
            var response = client.Execute(request);
            return response;
        }
        public T Execute<T>(IRestRequest request) where T : new()
        {
            request.DateFormat = string.IsNullOrEmpty(request.DateFormat) ? DefaultDateParameterFormat : request.DateFormat;
            var response = client.Execute<T>(request);
            return response.Data;
        }
        public RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse> callback)
        {
            request.DateFormat = string.IsNullOrEmpty(request.DateFormat) ? DefaultDateParameterFormat : request.DateFormat;
            return client.ExecuteAsync(request, callback);
        }
        public RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>> callback) where T : new()
        {
            request.DateFormat = string.IsNullOrEmpty(request.DateFormat) ? DefaultDateParameterFormat : request.DateFormat;
            return client.ExecuteAsync<T>(request, callback);
        }
    }
}
