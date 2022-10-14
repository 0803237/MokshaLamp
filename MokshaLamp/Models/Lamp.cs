using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MokshaLamp.Models
{
    public class Lamp
    {
        public int Id { get; set; }
        public string Category { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        public string Color { get; set; }

        public string Material { get; set; }

        public int Dimension { get; set; }

        [Range(1, 500), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
