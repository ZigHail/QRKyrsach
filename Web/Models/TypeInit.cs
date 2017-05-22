using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TypeInit : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.ProductTypes.Add(new ProductType { Type = "Яблуко", IsFood = true });
            context.ProductTypes.Add(new ProductType { Type = "Молоко", IsFood = true });
            context.ProductTypes.Add(new ProductType { Type = "Гречка", IsFood = true });
            context.ProductTypes.Add(new ProductType { Type = "Телевізор", IsFood = false });

            base.Seed(context);
        }
    }
}