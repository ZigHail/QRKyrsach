using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;
using System.Data.Entity;

namespace Web.BussinessLogic
{
    public class Product : IAdd<Models.Product>
    {
        private Models.Product product { get; set; }

        public Product()
        {
        }
        public Product(Models.Product food)
        {
            this.product = food;

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
        public void Add(Models.Product product)
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
        public static void Delete(Models.Product product)
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
        public static Models.Product Read(string ean13)
        {
            using (var db = new ProductContext())
            {
                var p = db.Products.FirstOrDefault(cf => cf.EAN13 == ean13);
                return p;
            }
        }

        public void Update()
        {
            using (var db = new ProductContext())
            {
                var currentProduct = db.Products.FirstOrDefault(cf => cf.Id == product.Id);
                Update(currentProduct);
            }
        }
        public static void Update(Models.Product product)
        {
            using (var db = new ProductContext())
            {
                var currentProduct = db.Products.FirstOrDefault(cf => cf.EAN13 == product.EAN13);
                currentProduct.EAN13 = product.EAN13;

                currentProduct.Manufacturer = product.Manufacturer;
                currentProduct.Name = product.Name;
                currentProduct.Price = product.Price;
                currentProduct.ProductTypeId = product.ProductTypeId;
                currentProduct.ShelfLifeInDays = product.ShelfLifeInDays;
                db.SaveChanges();
            }
        }

        public Models.ProductType GetProductType() => product.ProductType;

        public static List<string> GetAllEAN13()
        {
            using (var db = new ProductContext())
            {
                return db.Products.Select(p => p.EAN13).ToList();
            }
        }
    }
}