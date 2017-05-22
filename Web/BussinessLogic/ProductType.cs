using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.BussinessLogic
{
    public class ProductType : CRUD<Models.ProductType>
    {
        public ProductType()
        {
            All = GetAll();
        }
        public override List<Models.ProductType> GetAll()
        {
            using (var db = new ProductContext())
            {
                return db.ProductTypes.ToList();
            }
        }

        public override void Add(Models.ProductType t)
        {
            var db = new ProductContext();
            db.ProductTypes.Add(t);
            db.SaveChanges();
        }

        public override void Delete(Models.ProductType t)
        {
            using (var db = new ProductContext())
            {
                db.ProductTypes.Remove(t);
                db.SaveChanges();
            }
        }

        public override Models.ProductType Read(int id)
        {
            return new ProductContext().ProductTypes.Find(id);
        }

        public override void Update(Models.ProductType t)
        {
            using (var db = new ProductContext())
            {
                db.Entry(t).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        
    }
}