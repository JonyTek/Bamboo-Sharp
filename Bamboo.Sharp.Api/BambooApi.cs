using Bamboo.Sharp.Api.Authentication;
using Bamboo.Sharp.Api.Factories;
using Bamboo.Sharp.Api.Services;

namespace Bamboo.Sharp.Api
{
    public class BambooApi
    {
        internal static string BaseUrl { get; set; }

        public T GetService<T>()
            where T : IService, new()
        {
            return ServiceFactory.GetService<T>();
        }

        public BambooApi(string baseUrl, string userName, string password)
        {
            BaseUrl = baseUrl;

            Authenticator.Setup(userName, password);
        }
    }


}
