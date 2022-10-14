using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MokshaLamp.Models
{
    public class Lamp
    {
        public int Id { get; set; }
        public string Category { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        public string Color { get; set; }

        public string Material { get; set; }

        public int Dimension { get; set; }

        public decimal Price { get; set; }
    }
}
