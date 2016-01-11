using System.Collections.Generic;
using Bamboo.Sharp.Api.Model;
using RestSharp;

namespace Bamboo.Sharp.Api.Services
{
    public class DeployService : BaseService
    {
        public object DeployProject()
        {
            var request = new RestRequest
            {
                Resource = "deploy/project ", Method = Method.PUT
            };

            return Client.Execute<object>(request);
        }

        public object DeployProject(int id)
        {
            var request = new RestRequest
            {
                Resource = "deploy/project/{id} ",
                Method = Method.POST
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetVersionStatus(int id, int state)
        {
            var request = new RestRequest
            {
                Resource = "deploy/version/{id}/status/{state} ",
                Method = Method.POST
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);
            request.AddParameter("state", state, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetAllProjects()
        {
            var request = new RestRequest
            {
                Resource = "deploy/project/all ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }


        public DeployProject GetProject(int id)
        {
            var request = new RestRequest
            {
                Resource = "deploy/project/{id} ",
                Method = Method.GET
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return Client.Execute<DeployProject>(request);
        }


        public object GetProjectVersioningNextVersion(int id)
        {
            var request = new RestRequest
            {
                Resource = "deploy/projectVersioning/{id}/nextVersion ",
                Method = Method.GET
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetProjectVersioningNamingPreview(int id)
        {
            var request = new RestRequest
            {
                Resource = "deploy/projectVersioning/{id}/namingPreview ",
                Method = Method.GET
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetProjectVersioningParseVariables(int id)
        {
            var request = new RestRequest
            {
                Resource = "deploy/projectVersioning/{id}/parseVariables ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }

        public object GetProjectForPlan(int projectId)
        {
            var request = new RestRequest
            {
                Resource = "deploy/project/{projectId}/versions ",
                Method = Method.GET
            };

            request.AddParameter("projectId", projectId, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetProjectForPlan()
        {
            var request = new RestRequest
            {
                Resource = "deploy/project/forPlan ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }

        public List<DeployProject> GetProjectForPlan(string planKey)
        {
            var request = new RestRequest
            {
                Resource = string.Format("deploy/project/forPlan?planKey={0}", planKey),
                Method = Method.GET
            };
         
            return Client.Execute<List<DeployProject>>(request);
        }

        public object GetProjectVersioning(int id)
        {
            var request = new RestRequest
            {
                Resource = "deploy/projectVersioning/{id}/variables ",
                Method = Method.GET
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetVersionStatus(int id)
        {
            var request = new RestRequest
            {
                Resource = "deploy/version/{id}/status ",
                Method = Method.GET
            };

            request.AddParameter("id", id, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetIssueStatus(int key, int deploymentProjectId)
        {
            var request = new RestRequest
            {
                Resource = "deploy/issue-status/{key}/{deploymentProjectId} ",
                Method = Method.GET
            };

            request.AddParameter("key", key, ParameterType.UrlSegment);
            request.AddParameter("deploymentProjectId", key, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetIssueStatus(int key)
        {
            var request = new RestRequest
            {
                Resource = "deploy/issue-status/{key} ",
                Method = Method.GET
            };

            request.AddParameter("key", key, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetDashboard(int projectId)
        {
            var request = new RestRequest
            {
                Resource = "deploy/dashboard/{projectId} ",
                Method = Method.GET
            };

            request.AddParameter("projectId", projectId, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public object GetDashboard()
        {
            var request = new RestRequest
            {
                Resource = "deploy/dashboard ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }

        public object GetEnvironment(int environmentId)
        {
            var request = new RestRequest
            {
                Resource = "deploy/environment/{environmentId}/results ",
                Method = Method.GET
            };

            request.AddParameter("environmentId", environmentId, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }

        public DeployResults GetEnvironmentResults(int environmentId)
        {
            var request = new RestRequest
            {
                Resource = "deploy/environment/{environmentId}/results",
                Method = Method.GET
            };

            request.AddParameter("environmentId", environmentId, ParameterType.UrlSegment);

            return Client.Execute<DeployResults>(request);
        }

        public object GetPreviewVersion()
        {
            var request = new RestRequest
            {
                Resource = "deploy/preview/versionName ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }

        public object GetPreviewPossibleResult()
        {
            var request = new RestRequest
            {
                Resource = "deploy/preview/possibleResults ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }

        public object GetPreviewResult()
        {
            var request = new RestRequest
            {
                Resource = "deploy/preview/result ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }

        public object GetVersion()
        {
            var request = new RestRequest
            {
                Resource = "deploy/preview/version ",
                Method = Method.GET
            };

            return Client.Execute<object>(request);
        }

        public object GetResult(int deploymentResultId)
        {
            var request = new RestRequest
            {
                Resource = "deploy/result/{deploymentResultId} ",
                Method = Method.GET
            };

            request.AddParameter("deploymentResultId", deploymentResultId, ParameterType.UrlSegment);

            return Client.Execute<object>(request);
        }
    }
}