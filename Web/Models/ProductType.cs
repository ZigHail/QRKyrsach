using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        [Display(Name = "Тип")]
        public string Type { get; set; }
        [Display(Name = "Їжа")]
        public bool IsFood { get; set; }

        public ICollection<Product> Product { get; set; }


        public ProductType()
        {
            Product = new List<Product>();
        }
    }
}