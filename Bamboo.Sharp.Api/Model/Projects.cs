using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class Projects : BaseNode
    {
        [DeserializeAs(Name = "project")]
        public List<Project> All { get; set; }
    }
}
