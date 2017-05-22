using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.BussinessLogic;

namespace Web.Controllers
{
    public class ProductsController : Controller
    {        

        // GET: Products
        public ActionResult Index()
        {            
            return View(new Product().GetAll());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            var product = new Product().Read((int)id);
            if (product == null)            
                return HttpNotFound();
            
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {            
            ViewBag.ProductTypeId = new SelectList(new ProductType().GetAll(), "Id", "Type");
            return View();
        }

        // POST: Products/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,EAN13,Manufacturer,Price,ShelfLifeInDays,ProductTypeId")] Models.Product product)
        {
            if (ModelState.IsValid)
            {
                new Product().Add(product);                
                return RedirectToAction("Index");
            }

            ViewBag.ProductTypeId = new SelectList(new ProductType().GetAll(), "Id", "Type", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = new Product().Read((int)id);
            if (product == null)            
                return HttpNotFound();
            
            ViewBag.ProductTypeId = new SelectList(new ProductType().GetAll(), "Id", "Type", product.ProductTypeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,EAN13,Manufacturer,Price,ShelfLifeInDays,ProductTypeId")] Models.Product product)
        {
            if (ModelState.IsValid)
            {
                new Product().Update(product);
                return RedirectToAction("Index");
            }
            ViewBag.ProductTypeId = new SelectList(new ProductType().GetAll(), "Id", "Type", product.ProductTypeId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = new Product().Read((int)id);
            if (product == null)            
                return HttpNotFound();
            
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {            
            new Product().Delete(new Product().Read(id));
            return RedirectToAction("Index");
        }
        
    }
}
