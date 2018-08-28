using Bamboo.Sharp.Api.Model;
using RestSharp;

namespace Bamboo.Sharp.Api.Services
{
    public class QueueService : BaseService
    {
        //Base requests
        public QueueResult QueuePlan(string plan)
        {
            var request = new RestRequest
            {
                Resource = "queue/{plan}?stage&executeAllStages",
                Method = Method.POST
            };

            request.AddParameter("plan", plan, ParameterType.UrlSegment);

            return Client.Execute<QueueResult>(request);
        }

        public Result GetResultForQueuedPlan(QueueResult result)
        {
            var request = new RestRequest
            {
                Resource = $"result/{result.BuildResultKey}",
                Method = Method.GET
            };

            return Client.Execute<Result>(request);
        }
    }
}