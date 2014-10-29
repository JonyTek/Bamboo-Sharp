using System.Linq;
using System.Threading.Tasks;
using Bamboo.Sharp.Api.Model;
using RestSharp;

namespace Bamboo.Sharp.Api.Services
{
    public class ProjectService : BaseService
    {
        //Supported resources
        private const string GetProjectsResource = "project?expand=projects.project.plans.plan.actions";
        private const string CloneResource = "clone/{projectKey}-{buildKey}:{toProjectKey}-{toBuildKey}";

        //Base requests
        private readonly IRestRequest _baseGetProjectsRequest = new RestRequest
        {
            Resource = GetProjectsResource,
            RootElement = "projects",
            Method = Method.GET
        };

        private readonly IRestRequest _baseCloneRequest = new RestRequest
        {
            Resource = CloneResource,
            Method = Method.PUT
        };

        //Implemenations
        public Projects GetProjects()
        {
            return Client.Execute<Projects>(_baseGetProjectsRequest);
        }

        public async Task<Projects> GetProjectsAsync()
        {
            return await Client.ExecuteAsync<Projects>(_baseGetProjectsRequest);
        }

        public Project GetProject(string key)
        {
            return GetProjects().All.FirstOrDefault(p => p.Key.Equals(key));
        }

        public async Task<Project> GetProjectAsync(string key)
        {
            var projects = await GetProjectsAsync();

            return projects.All.FirstOrDefault(p => p.Key.Equals(key));
        }

        public Plan Clone(string fromProjKey, string fromBuildKey, string newProjectKey, string newBuildKey)
        {
            _baseCloneRequest.AddParameter("projectKey", fromProjKey, ParameterType.UrlSegment);
            _baseCloneRequest.AddParameter("buildKey", fromBuildKey, ParameterType.UrlSegment);
            _baseCloneRequest.AddParameter("toProjectKey", newProjectKey, ParameterType.UrlSegment);
            _baseCloneRequest.AddParameter("toBuildKey", newBuildKey, ParameterType.UrlSegment);

            return Client.Execute<Plan>(_baseCloneRequest);
        }

        public async Task<Plan> CloneAsync(string fromProjKey, string fromBuildKey, string newProjectKey, string newBuildKey)
        {
            _baseCloneRequest.AddParameter("projectKey", fromProjKey, ParameterType.UrlSegment);
            _baseCloneRequest.AddParameter("buildKey", fromBuildKey, ParameterType.UrlSegment);
            _baseCloneRequest.AddParameter("toProjectKey", newProjectKey, ParameterType.UrlSegment);
            _baseCloneRequest.AddParameter("toBuildKey", newBuildKey, ParameterType.UrlSegment);

            return await Client.ExecuteAsync<Plan>(_baseCloneRequest);
        }
    }
}
