using System;
using Bamboo.Sharp.Api.Model;
using RestSharp;

namespace Bamboo.Sharp.Api.Util
{
    public class RequestTypeConverter
    {
        internal static Method Convert(RequestType type)
        {
            switch (type)
            {
                case RequestType.GET:
                    return Method.GET;
                case RequestType.POST:
                    return Method.POST;
                case RequestType.PUT:
                    return Method.PUT;
                default:
                    throw new ArgumentException("Request type");
            }
        }
    }
}
