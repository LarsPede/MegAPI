using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MegaLight.Models
{
    public class Light
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public bool Controller { get; set; }
        public string Animation { get; set; }
        public float Brightness { get; set; }
        public Color Color { get; set; }
    }
}