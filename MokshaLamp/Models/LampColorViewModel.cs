using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MokshaLamp.Models
{
    public class LampColorViewModel
    {
        public List<Lamp> Lamps { get; set; }
        public SelectList Color { get; set; }
        public string LampColor { get; set; }
        public string SearchString { get; set; }
        public SelectList Colors { get; internal set; }
    }
}
