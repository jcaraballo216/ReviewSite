using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Category
    {
        //Setting the properties
        [Key]
        public int CategoryID { get; set; }
        public string Brand { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}