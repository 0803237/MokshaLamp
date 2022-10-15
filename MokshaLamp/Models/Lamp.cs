using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace MokshaLamp.Models
{
    public class Lamp
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 4)]
        public string Category { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime ManufactureDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string Color { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Material { get; set; }

        [Range(1,45)]
        [Required]
        public int Dimension { get; set; }

        [Range(1, 300), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Price { get; set; }


        [Range(1, 5)]
        public string Rating { get; set; }
    }
}
