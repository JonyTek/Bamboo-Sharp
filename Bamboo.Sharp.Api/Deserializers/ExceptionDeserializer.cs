using Bamboo.Sharp.Api.Model;
using Newtonsoft.Json;

namespace Bamboo.Sharp.Api.Deserializers
{
    internal static class ExceptionDeserializer
    {
        internal static WebException Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<WebException>(json);
        }
    }
}
