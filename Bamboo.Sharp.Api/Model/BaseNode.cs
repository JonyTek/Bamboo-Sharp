using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class BaseNode
    {
        public int Size { get; set; }

        [DeserializeAs(Name = "start-index")]
        public int StartIndex { get; set; }

        [DeserializeAs(Name = "max-result")]
        public int MaxResults { get; set; }
    }
}
