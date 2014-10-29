using Bamboo.Sharp.Api.Services;

namespace Bamboo.Sharp.Api.Factories
{
    internal static class ServiceFactory
    {
        public static T GetService<T>()
            where T : IService, new()
        {
            return new T();
        }
    }
}
