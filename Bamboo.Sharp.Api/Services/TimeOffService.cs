using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bamboo.Sharp.Api.Model;

namespace Bamboo.Sharp.Api.Services
{
    public class TimeOffService : BaseService
    {
        public Calendar GetWhosOutToday(DateTime? startDate = null, DateTime? endDate = null)
        {
            //If there is an end date, must have a start date.
            if (!startDate.HasValue && endDate.HasValue)
                throw new DataMisalignedException("You must specify a Start Date if you specify an EndDate!");
            // End date has to be == or after the start date.
            if (endDate.HasValue && startDate.HasValue && endDate.Value.Subtract(startDate.Value).TotalDays <= 0)
                throw new DataMisalignedException("Your End Date must equal to or after your startDate");
            if(endDate.HasValue && (endDate.Value.Subtract(startDate.Value).TotalDays > 14) )
                throw new DataMisalignedException("Your entire search scope may only be up to 14 days from the start request!");

            var start = startDate.HasValue == true ? startDate.Value.ToString("yyyy-M-d") : string.Empty;
            var end = endDate.HasValue == true ? endDate.Value.ToString("yyyy-M-d") : string.Empty;

            var request = new RestRequest
            {
                Resource = "time_off/whos_out",
                Method = Method.GET
            };
            if(!string.IsNullOrEmpty(start))
                request.AddQueryParameter("start", start);

            if(!string.IsNullOrEmpty(end))
                request.AddQueryParameter("end", end);

            return Client.Execute<Calendar>(request);
        }
    }
}
