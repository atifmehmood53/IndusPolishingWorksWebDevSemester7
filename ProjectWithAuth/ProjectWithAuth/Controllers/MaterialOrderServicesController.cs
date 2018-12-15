using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectWithAuth.Models;

namespace ProjectWithAuth.Controllers
{
    [Authorize(Roles = "Owner,Employee")]
    public class MaterialOrderServicesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: MaterialOrderServices
        /*public ActionResult Index()
        {
            var materialOrderServices = db.MaterialOrderServices.Include(m => m.Order).Include(m => m.Service);
            return View(materialOrderServices.ToList());
        }

        // GET: MaterialOrderServices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaterialOrderService materialOrderService = db.MaterialOrderServices.Find(id);
            if (materialOrderService == null)
            {
                return HttpNotFound();
            }
            return View(materialOrderService);
        }
        */
        // GET: MaterialOrderServices/Create
        public ActionResult Create(int OrderID)
        {
            ViewBag.OrderID = OrderID;//new SelectList(db.orders, "ID", "Weight");
            ViewBag.ServiceID = new SelectList(db.services, "ID", "Name");
            ViewBag.MaterialID = new SelectList(db.Materials, "ID", "Name");
            return View();
        }

        // POST: MaterialOrderServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ServiceID,OrderID,MaterialID")] MaterialOrderService materialOrderService)
        {
            if (ModelState.IsValid)
            {
                db.MaterialOrderServices.Add(materialOrderService);
                db.SaveChanges();
                return RedirectToAction("Edit","Orders", new { id= materialOrderService.OrderID });
            }

            ViewBag.OrderID = materialOrderService.OrderID;//new SelectList(db.orders, "ID", "Weight");
            ViewBag.ServiceID = new SelectList(db.services, "ID", "Name", materialOrderService.ServiceID);
            ViewBag.MaterialID = new SelectList(db.Materials, "ID", "Name", materialOrderService.MaterialID);
            return View(materialOrderService);
        }
        /*
        // GET: MaterialOrderServices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaterialOrderService materialOrderService = db.MaterialOrderServices.Find(id);
            if (materialOrderService == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrderID = materialOrderService.OrderID;
            ViewBag.ServiceID = new SelectList(db.services, "ID", "Name", materialOrderService.ServiceID);
            ViewBag.MaterialID = new SelectList(db.Materials, "ID", "Name", materialOrderService.MaterialID);
            return View(materialOrderService);
        }

        // POST: MaterialOrderServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ServiceID,OrderID")] MaterialOrderService materialOrderService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materialOrderService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrderID = materialOrderService.OrderID;
            ViewBag.ServiceID = new SelectList(db.services, "ID", "Name", materialOrderService.ServiceID);
            ViewBag.MaterialID = new SelectList(db.Materials, "ID", "Name", materialOrderService.MaterialID);
            return View(materialOrderService);
        }
        */
        // GET: MaterialOrderServices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MaterialOrderService materialOrderService = db.MaterialOrderServices.Find(id);
            if (materialOrderService == null)
            {
                return HttpNotFound();
            }
            return View(materialOrderService);
        }

        // POST: MaterialOrderServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MaterialOrderService materialOrderService = db.MaterialOrderServices.Find(id);
            int orderId = materialOrderService.OrderID;
            db.MaterialOrderServices.Remove(materialOrderService);
            db.SaveChanges();
            return RedirectToAction("Edit","Orders",new { id=orderId});
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
