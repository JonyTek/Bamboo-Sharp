using RestSharp;

namespace Bamboo.Sharp.Api.Deserializers
{
    public interface IDeserialize<out T>
    {
        T Deserialize(IRestResponse response);
    }
}
