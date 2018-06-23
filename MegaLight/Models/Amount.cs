using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MegaLight.Models
{
    public class Amount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public float Up { get; set; }
        public float Down { get; set; }
        public DateTime DateTime { get; set; }

        public static implicit operator Amount(UpDown ud)
        {
            Amount amnt = new Amount
            {
                Up = ud.Up,
                Down = ud.Down,
                DateTime = DateTime.Now
            };
            return amnt;
        }
    }
}