using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class Holiday
    {
        [DeserializeAs(Name = "id", Attribute = true)]
        public string Id { get; set; }
        //[XmlText]
        public string Value { get; set; }
    }
}
