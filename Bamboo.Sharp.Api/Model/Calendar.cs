using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class Calendar : BaseNode
    {
        public List<item> WhosOut { get; set; }
    }
}
