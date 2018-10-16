using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Babysitter.Models
{
    public class Babysitter
    {
        public int StartHour { get; set; }
        public int BedtimeHour { get; set; }
        public int EndtimeHour { get; set; }
    }
}