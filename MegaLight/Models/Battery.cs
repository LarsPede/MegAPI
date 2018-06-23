using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MegaLight.Models
{
    public class Battery
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string BatteryId { get; set; }
        public float Voltage { get; set; }
        public DateTime DateTime { get; set; }
    }
}