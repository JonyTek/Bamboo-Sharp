using Bamboo.Sharp.Api.Clients;

namespace Bamboo.Sharp.Api.Services
{
    public class BaseService : IService
    {
        internal readonly RequestClient Client;
        
        protected BaseService()
        {
            Client = RequestClient.Instance;
        }
    }
}
