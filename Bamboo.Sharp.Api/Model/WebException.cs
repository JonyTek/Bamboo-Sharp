using Newtonsoft.Json;

namespace Bamboo.Sharp.Api.Model
{
    public class WebException
    {
        [JsonProperty(PropertyName = "status-code")]
        public int StatusCode { get; set; }

        public string Message { get; set; }
    }
}
