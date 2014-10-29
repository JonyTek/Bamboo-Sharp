using System;

namespace Bamboo.Sharp.Api.Extensions
{
    internal static class TypeExtensions
    {
        internal static bool Is<T>(this Type type)
        {
            return type == typeof (T);
        }
    }
}
