using MegaLight.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaLight.Models
{
    public class BatteryWeek
    {
        public BatteryWeek()
        {
            Monday = new float[6];
            Tuesday = new float[6];
            Wednesday = new float[6];
            Thursday = new float[6];
            Friday = new float[6];
            Saturday = new float[6];
            Sunday = new float[6];
        }
        public float[] Monday { get; set; }
        public float[] Tuesday { get; set; }
        public float[] Wednesday{ get; set; }
        public float[] Thursday { get; set; }
        public float[] Friday { get; set; }
        public float[] Saturday { get; set; }
        public float[] Sunday { get; set; }

    }
}