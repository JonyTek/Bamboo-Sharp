using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamboo.Sharp.Api.Model
{
    public class Results : BaseNode
    {
        //[DeserializeAs(Name = "result")]
        public List<Result> result { get; set; }
    }
}
