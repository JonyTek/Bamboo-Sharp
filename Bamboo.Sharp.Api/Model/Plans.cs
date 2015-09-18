using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Bamboo.Sharp.Api.Model
{
    public class Plans : BaseNode
    {
        [DeserializeAs(Name = "plan")]
        public List<Plan> All { get; set; }
    }
}
