using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestApp.Models
{
    /// <summary>
    /// A category for BlogPost objects to live in. BlogPosts can have exactyl one category. 
    /// </summary>
    public class BlogCategory
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}
