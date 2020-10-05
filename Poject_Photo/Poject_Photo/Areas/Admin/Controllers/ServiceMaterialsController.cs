using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Poject_Photo.DAL;
using Poject_Photo.Models;

namespace Poject_Photo.Areas.Admin.Controllers
{
    public class ServiceMaterialsController : Controller
    {
        private WebPhotoContext db = new WebPhotoContext();

        // GET: Admin/ServiceMaterials
        public ActionResult Index()
        {
            return View(db.ServiceMaterials.ToList());
        }

        // GET: Admin/ServiceMaterials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceMaterial serviceMaterial = db.ServiceMaterials.Find(id);
            if (serviceMaterial == null)
            {
                return HttpNotFound();
            }
            return View(serviceMaterial);
        }

        // GET: Admin/ServiceMaterials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ServiceMaterials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SMName,Price,Status,Created")] ServiceMaterial serviceMaterial)
        {
            if (ModelState.IsValid)
            {
                db.ServiceMaterials.Add(serviceMaterial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceMaterial);
        }

        // GET: Admin/ServiceMaterials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceMaterial serviceMaterial = db.ServiceMaterials.Find(id);
            if (serviceMaterial == null)
            {
                return HttpNotFound();
            }
            return View(serviceMaterial);
        }

        // POST: Admin/ServiceMaterials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SMName,Price,Status,Created")] ServiceMaterial serviceMaterial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceMaterial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceMaterial);
        }

        // GET: Admin/ServiceMaterials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceMaterial serviceMaterial = db.ServiceMaterials.Find(id);
            if (serviceMaterial == null)
            {
                return HttpNotFound();
            }
            return View(serviceMaterial);
        }

        // POST: Admin/ServiceMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceMaterial serviceMaterial = db.ServiceMaterials.Find(id);
            db.ServiceMaterials.Remove(serviceMaterial);
            db.SaveChanges();
            return RedirectToAction("Index");
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
