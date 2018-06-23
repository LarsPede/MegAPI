using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaLight.Models
{
    public class Status
    {
        public UpDown Avg { get; set; }
        public DataWeek DataWeek { get; set; }
        public BatteryWeek BatteryWeek { get; set; }
    }
}