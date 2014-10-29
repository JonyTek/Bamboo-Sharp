using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Bamboo.Sharp.Api.Model
{
    public class SearchResultSet : List<SearchResult>
    {
    }

    public class SearchResult
    {
        public string Id { get; set; }

        [DeserializeAs(Name = "searchEntity.branchName")]
        public string BranchName { get; set; }

        [DeserializeAs(Name = "searchEntity.description")]
        public string Description { get; set; }

        [DeserializeAs(Name = "searchEntity.key")]
        public string Key { get; set; }

        [DeserializeAs(Name = "searchEntity.planName")]
        public string PlanName { get; set; }

        [DeserializeAs(Name = "searchEntity.projectName")]
        public string ProjectName { get; set; }

        [DeserializeAs(Name = "searchEntity.type")]
        public Type Type { get; set; }

        [DeserializeAs(Name = "searchEntity.userName")]
        public string UserName { get; set; }

        [DeserializeAs(Name = "searchEntity.fullName")]
        public string FullName { get; set; }
    }
}
