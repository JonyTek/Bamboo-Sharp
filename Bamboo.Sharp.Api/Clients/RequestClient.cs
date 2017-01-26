using Bamboo.Sharp.Api.Authentication;
using Bamboo.Sharp.Api.Deserializers;
using Bamboo.Sharp.Api.Exceptions;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Bamboo.Sharp.Api.Clients
{
    internal class RequestClient
    {
        private static RequestClient _instance;
        private static readonly object Lock = new object();

        private RequestClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        }

        internal static RequestClient Instance
        {
            get
            {
                lock (Lock)
                {
                    return _instance ?? (_instance = new RequestClient());
                }
            }
        }

        private RestClient _client;

        internal T Execute<T>(IRestRequest request)
            where T : new()
        {
            _client = Authenticator.Authenticate();
            _client.BaseUrl = new Uri(BambooApi.BaseUrl);
            
            var response = _client.Execute<T>(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException("Unable to authenticate. Please check your credentials.");
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new InternalServerError(ExceptionDeserializer.Deserialize(response.Content));
            }

            return response.Data;
        }

        internal async Task<T> ExecuteAsync<T>(IRestRequest request)
            where T : new()
        {
            var tcs = new TaskCompletionSource<T>();
            
            _client = Authenticator.Authenticate();
            _client.BaseUrl = new Uri(BambooApi.BaseUrl);
            _client.ExecuteAsync<T>(request, response => tcs.SetResult(response.Data));

            var task = tcs.Task;

            if (task.Exception != null)
            {
                var message = task.Exception.Flatten().Message;

                throw new InternalServerError(message);
            }

            return await task;
        }
    }
}
