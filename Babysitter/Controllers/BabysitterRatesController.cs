using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Babysitter.Models;

namespace Babysitter.Controllers
{
    public class BabysitterRatesController : ApiController
    {
        private const int prime_rate = 12;
        private const int post_bedtime_rate = 8;
        private const int after_hours_rate = 15;

        public string Get()
        {
            return string.Empty;
        }
        public string Get(int id)
        {
            return string.Empty;
        }

        public string Get(int StartHour, int BedtimeHour, int EndtimeHour)
        {
            var total_pay = GetPrimeRate(StartHour, BedtimeHour);
            total_pay += GetPostBedtimeRate(BedtimeHour);
            total_pay += GetAfterHoursRate(BedtimeHour, EndtimeHour);
            return total_pay.ToString();
        }


        public double GetPrimeRate(int starttime, int bedtime)
        {
            var total_hours = bedtime - starttime;
            var total_pay = total_hours * prime_rate;
            return total_pay;
        }

        public double GetPostBedtimeRate(int bedtime)
        {
            var total_hours = 24 - bedtime;
            var total_pay = total_hours * post_bedtime_rate;
            return total_pay;
        }

        public double GetAfterHoursRate(int bedtime, int endtime)
        {
            double total_pay;
            if (endtime < 24)
            {
                total_pay = (endtime - post_bedtime_rate) * after_hours_rate;
            }
            else
            {
                total_pay = endtime * after_hours_rate;
            }
            return total_pay;
        }
    }
}
