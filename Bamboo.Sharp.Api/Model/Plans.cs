using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class Plans : BaseNode
    {
        [DeserializeAs(Name = "plan")]
        public List<Plan> All { get; set; }
    }
}
