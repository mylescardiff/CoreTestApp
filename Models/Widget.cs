using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestApp.Models
{
    public class Widget
    {
        [Key]
        public int WidgetID { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal RandomNumber { get; set; }
    }
}
