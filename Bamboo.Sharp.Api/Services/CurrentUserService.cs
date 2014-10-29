using System.Threading.Tasks;
using Bamboo.Sharp.Api.Model;
using RestSharp;

namespace Bamboo.Sharp.Api.Services
{
    public class CurrentUserService : BaseService
    {
        //Supported resources
        private const string CurrentUserResource = "currentUser.json";

        //Base requests
        private readonly IRestRequest _baseCurrentuserRequest = new RestRequest
        {
            Resource = CurrentUserResource,
            Method = Method.GET
        };

        //Implemenations
        public User GetUser()
        {
            return Client.Execute<User>(_baseCurrentuserRequest);
        }

        public async Task<User> GetUserAsync()
        {
            return await Client.ExecuteAsync<User>(_baseCurrentuserRequest);
        }
    }
}
