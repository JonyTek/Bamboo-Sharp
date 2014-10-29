namespace Bamboo.Sharp.Api.Specs.Services
{
    public static class ServiceSpecHelper
    {
        public static BambooApi Api
        {
            get
            {
                return new BambooApi(
                    "http://192.168.56.1:8085/rest/api/latest",
                    "jonytek",
                    "password");
            }
        }
    }
}
