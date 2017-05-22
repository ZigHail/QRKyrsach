using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.BussinessLogic
{
    public class ProductType : IAdd<Models.ProductType>
    {
        public static List<Models.ProductType> GetAllProductTypes()
        {
            using (var db = new ProductContext())
            {
                return db.ProductTypes.ToList();
            }
        }        

        public void Add(Models.ProductType t)
        {
            var db = new ProductContext();
            db.ProductTypes.Add(t);
            db.SaveChanges();
        }

        //public static void Add(Models.ProductType type)
        //{
        //    var db = new ProductContext();
        //    db.ProductTypes.Add(type);
        //    db.SaveChanges();
        //}
}
}