using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class Authors : List<Author>{ }

    public class Author
    {
        [DeserializeAs(Name = "searchEntity.authorName")]
        public string AuthorName { get; set; }

        [DeserializeAs(Name = "searchEntity.id")]
        public string Name { get; set; }
    }
}
