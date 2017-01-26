using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace Bamboo.Sharp.Api.Model
{
    public class item
    {
        public Employee Employee { get; set; }

        public Holiday Holiday { get; set; }

        [DeserializeAs(Name = "start")]
        public DateTime StartDate { get; set; }

        [DeserializeAs(Name = "end")]
        public DateTime EndDate { get; set; }

        public bool IsHoliday()
        {
            return this.Holiday != null;
        }
        public bool IsEmployee()
        {
            return this.Employee != null;
        }

    }
}
