using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class Employee
    {
        [DeserializeAs(Name = "id", Attribute = true)]
        public string Id { get; set; }
        //[XmlText]
        public string Value { get; set; }


        public override string ToString()
        {
            return string.Format("({0}) - {1}", Id.ToString(), Value);
        }
    }
}
