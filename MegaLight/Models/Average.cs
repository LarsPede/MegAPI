using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MegaLight.Models
{
    public class Average
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public float Up { get; set; }
        public float Down { get; set; }
        public DateTime DateTime { get; set; }

        public static implicit operator Average(UpDown ud)
        {
            Average avg = new Average
            {
                Up = ud.Up,
                Down = ud.Down,
                DateTime = DateTime.Now
            };
            return avg;
        }
    }
}