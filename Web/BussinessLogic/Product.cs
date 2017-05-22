using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;
using System.Data.Entity;

namespace Web.BussinessLogic
{
    public class Product : CRUD<Models.Product>
    {
        private Models.Product product { get; set; }

        public Product()
        {
            All = GetAll();
        }
        public Product(Models.Product food)
        {
            product = food;
        }
        public Product(string ean13)
        {
            using (var db = new ProductContext())
            {
                product = db.Products
                    .Include(p => p.ProductType)
                    .FirstOrDefault(cf => cf.EAN13 == ean13);
            }
        }

        public void Add()
        {
            Add(product);
        }
        public override void Add(Models.Product product)
        {
            using (var db = new ProductContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            Delete(product);
        }
        public override void Delete(Models.Product product)
        {
            using (var db = new ProductContext())
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
        }

        public Models.Product Read()
        {
            return product;
        }
        public override Models.Product Read(int id)
        {
            return new ProductContext().Products.Find(id);
        }
        public static Models.Product Read(string ean13)
        {
            return new ProductContext().Products.FirstOrDefault(cf => cf.EAN13 == ean13);
        }

        public void Update()
        {
            using (var db = new ProductContext())
            {
                var currentProduct = db.Products.FirstOrDefault(cf => cf.Id == product.Id);
                Update(currentProduct);
            }
        }
        public override void Update(Models.Product product)
        {
            using (var db = new ProductContext())
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
            }
        }        
        

        public Models.ProductType GetProductType()
        {
            return product.ProductType;
        }

        public static List<string> GetAllEAN13()
        {
            using (var db = new ProductContext())
            {
                return db.Products.Select(p => p.EAN13).ToList();
            }
        }

        public override List<Models.Product> GetAll()
        {
            return new ProductContext()
            .Products
            .Include(p => p.ProductType)
            .ToList();
        }
    }
}