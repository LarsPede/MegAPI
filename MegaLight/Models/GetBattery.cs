using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaLight.Models
{
    public class GetBattery
    {
        public string BatteryId { get; set; }
        public float Voltage { get; set; }
        public bool CurrentBattery { get; set; }
    }
}