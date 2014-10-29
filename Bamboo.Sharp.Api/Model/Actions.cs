using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Bamboo.Sharp.Api.Model
{
    public class Actions : BaseNode
    {
        [DeserializeAs(Name = "action")]
        public List<Action> All { get; set; }
    }
}