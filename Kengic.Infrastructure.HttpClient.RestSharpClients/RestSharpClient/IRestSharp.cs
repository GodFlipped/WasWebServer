using System;
using RestSharp;

namespace WasWebServerCore.Kengic.Infrastructure.HttpClient.RestSharpClients.RestSharpClient
    {
    public interface IRestSharp
    {
        IRestResponse Execute(IRestRequest request);

        T Execute<T>(IRestRequest request) where T : new();

        RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse> callback);

        RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>> callback) where T : new();
         
    }
}
