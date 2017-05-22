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
    public class ProductTypesController : Controller
    {        

        // GET: ProductTypes
        public ActionResult Index()
        {
            return View(new ProductType().GetAll());
        }

        // GET: ProductTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var productType = new ProductType().Read((int)id);
            if (productType == null)            
                return HttpNotFound();
            
            return View(productType);
        }

        // GET: ProductTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductTypes/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,IsFood")] Models.ProductType productType)
        {
            if (ModelState.IsValid)
            {
                new ProductType().Add(productType);                
                return RedirectToAction("Index");
            }

            return View(productType);
        }

        // GET: ProductTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            var productType = new ProductType().Read((int)id);
            if (productType == null)            
                return HttpNotFound();
            
            return View(productType);
        }

        // POST: ProductTypes/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,IsFood")] Models.ProductType productType)
        {
            if (ModelState.IsValid)
            {
                new ProductType().Update(productType);
                return RedirectToAction("Index");
            }
            return View(productType);
        }

        // GET: ProductTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            var productType = new ProductType().Read((int)id);
            if (productType == null)            
                return HttpNotFound();
            
            return View(productType);
        }

        // POST: ProductTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            new ProductType().Delete(new ProductType().Read(id));
            return RedirectToAction("Index");
        }
        
    }
}
