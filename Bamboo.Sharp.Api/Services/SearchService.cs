using Bamboo.Sharp.Api.Extensions;
using Bamboo.Sharp.Api.Model;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bamboo.Sharp.Api.Services
{
    public class SearchService : BaseService
    {
        //Supported resources
        private const string SearchUsersResource =
            "search/users?searchTerm={searchTerm}" +
            "&includeAvatars{includeAvatars}";

        private const string SearchAuthorsResource =
            "search/authors?searchTerm={searchTerm}" +
            "&unlinkedOnly{unlinkedOnly}";

        private const string SearchPlansResource =
            "search/plans?searchTerm={searchTerm}";

        private const string SearchBranchesResource =
            "/search/branches?masterPlanKey={masterPlanKey}" +
            "&includeMasterBranch={includeMasterBranch}" +
            "&searchTerm={searchTerm}";

        private const string RootElement = "searchResults";

        //Base requests
        private IRestRequest _baseSearchRequest(string searchTerm = "")
        {
            var baseRequest = new RestRequest
            {
                RootElement = RootElement,
                Method = Method.GET
            };

            baseRequest.AddParameter("searchTerm", searchTerm, ParameterType.UrlSegment);

            return baseRequest;
        }

        private IRestRequest _baseSearchUsersRequest(string searchTerm = "", bool includeAvatars = true)
        {
            var request = _baseSearchRequest(searchTerm);
            request.Resource = SearchUsersResource;
            request.AddParameter("includeAvatars", includeAvatars, ParameterType.UrlSegment);

            return request;
        }

        private IRestRequest _baseSearchAuthorsRequest(string searchTerm, bool unlinkedOnly = true)
        {
            var request = _baseSearchRequest(searchTerm);
            request.Resource = SearchAuthorsResource;
            request.AddParameter("unlinkedOnly", unlinkedOnly, ParameterType.UrlSegment);

            return request;
        }

        private IRestRequest _baseSearchPlansRequest(string searchTerm = "")
        {
            var request = _baseSearchRequest(searchTerm);
            request.Resource = SearchPlansResource;

            return request;
        }

        private static IRestRequest BaseSearchBrancesRequest(
            string masterPlanKey,
            bool includeMasterBranch = true,
            int releasedInDeployment = -1,
            string searchTerm = "")
        {
            var request = new RestRequest
            {
                Resource = SearchBranchesResource,
                RootElement = RootElement,
                Method = Method.GET
            };

            request.AddParameter("masterPlanKey", masterPlanKey, ParameterType.UrlSegment);
            request.AddParameter("includeMasterBranch", includeMasterBranch, ParameterType.UrlSegment);

            if (releasedInDeployment != -1)
                request.Resource += string.Format("releasedInDeployment={0}", releasedInDeployment);

            request.AddParameter("searchTerm", searchTerm, ParameterType.UrlSegment);

            return request;
        }

        //Implemenations
        public IEnumerable<User> SearchUsers(string searchTerm, bool includeAvatars = true)
        {
            return Client.Execute<List<User>>(_baseSearchUsersRequest(searchTerm, includeAvatars));
        }

        public async Task<IEnumerable<User>> SearchUsersAsync(string searchTerm, bool includeAvatars = true)
        {
            return await Client.ExecuteAsync<List<User>>(_baseSearchUsersRequest(searchTerm, includeAvatars));
        }

        public Authors SearchAuthors(string searchTerm, bool unlinkedOnly = false)
        {
            return Client.Execute<Authors>(_baseSearchAuthorsRequest(searchTerm, unlinkedOnly));
        }

        public async Task<List<Author>> SearchAuthorsAsync(string searchTerm, bool unlinkedOnly = false)
        {
            return await Client.ExecuteAsync<List<Author>>(_baseSearchAuthorsRequest(searchTerm, unlinkedOnly));
        }

        public SearchResultSet SearchPlans(string searchTerm = "")
        {
            return Client.Execute<SearchResultSet>(_baseSearchPlansRequest(searchTerm));
        }

        public async Task<SearchResultSet> SearchPlansAsync(string searchTerm = "")
        {
            return await Client.ExecuteAsync<SearchResultSet>(_baseSearchPlansRequest(searchTerm));
        }

        public SearchResultSet SearchBranches(
            string masterPlanKey,
            bool includeMasterBranch = true,
            int releasedInDeployment = -1,
            string searchTerm = "")
        {
            return
                Client.Execute<SearchResultSet>(
                    BaseSearchBrancesRequest(
                        masterPlanKey,
                        includeMasterBranch,
                        releasedInDeployment,
                        searchTerm));
        }

        public async Task<SearchResultSet> SearchBranchesAsync(
            string masterPlanKey,
            bool includeMasterBranch = true,
            int releasedInDeployment = -1,
            string searchTerm = "")
        {
            return
                await Client.ExecuteAsync<SearchResultSet>(
                    BaseSearchBrancesRequest(
                        masterPlanKey,
                        includeMasterBranch,
                        releasedInDeployment,
                        searchTerm));
        }
    }
}

    

   