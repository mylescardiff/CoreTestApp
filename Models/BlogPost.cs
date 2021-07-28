using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestApp.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPostID { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public BlogCategory Category { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        // this should contain HTML code
        [Required]
        public string Content { get; set; }
    }
}
