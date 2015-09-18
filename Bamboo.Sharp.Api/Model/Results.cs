using System.Collections.Generic;

namespace Bamboo.Sharp.Api.Model
{
    public class Results : BaseNode
    {
        //[DeserializeAs(Name = "result")]
        public List<Result> result { get; set; }
    }
}
