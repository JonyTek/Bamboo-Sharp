using Bamboo.Sharp.Api.Services;

namespace Bamboo.Sharp.Api.Specs
{
    class Usage
    {
        public void Test()
        {
            var api = new BambooApi("base url", "username", "password");
            var projects = api.GetService<ProjectService>().GetProjects();
            var user = api.GetService<CurrentUserService>().GetUser();
        }
    }
}
