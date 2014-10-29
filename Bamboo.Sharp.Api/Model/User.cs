using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class Users : List<User> { }

    public class User
    {
        public string Email { get; set; }

        [DeserializeAs(Name = "searchEntity.fullName")]
        public string FullName { get; set; }

        [DeserializeAs(Name = "searchEntity.userName")]
        public string Name { get; set; }
    }
}
