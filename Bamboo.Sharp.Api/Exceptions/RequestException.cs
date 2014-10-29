using System;

namespace Bamboo.Sharp.Api.Exceptions
{
    internal class RequestException : Exception
    {
        internal RequestException(string message)
            :base(message)
        {
        }

    }
}
