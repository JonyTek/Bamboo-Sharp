using Bamboo.Sharp.Api.Model;
using System;

namespace Bamboo.Sharp.Api.Exceptions
{
    public class InternalServerError : Exception
    {
        public int StatucCode { get; private set; }

        public InternalServerError(WebException exception)
            : base(exception.Message)
        {
            StatucCode = exception.StatusCode;
        }

        public InternalServerError(string message)
            : base(message)
        {
            StatucCode = 500;
        }
    }
}
