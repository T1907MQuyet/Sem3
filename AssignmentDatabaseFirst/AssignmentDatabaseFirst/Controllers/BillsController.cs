using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AssignmentDatabaseFirst.Models;

namespace AssignmentDatabaseFirst.Controllers
{
    public class BillsController : Controller
    {
        private Assignment1Entities db = new Assignment1Entities();

        // GET: Bills
        public ActionResult Index()
        {
            var bills = db.Bills.Include(b => b.Member).Include(b => b.Service).Include(b => b.Employee);
            return View(bills.ToList());
        }

        // GET: Bills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bill bill = db.Bills.Find(id);
            if (bill == null)
            {
                return HttpNotFound();
            }
            return View(bill);
        }

        // GET: Bills/Create
        public ActionResult Create()
        {
            ViewBag.MemberID = new SelectList(db.Members, "ID", "email");
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "ServiceType");
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "LastName");
            return View();
        }

        // POST: Bills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MemberID,ServiceID,Price,Status,EmployeeID")] Bill bill)
        {
            if (ModelState.IsValid)
            {
                db.Bills.Add(bill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MemberID = new SelectList(db.Members, "ID", "email", bill.MemberID);
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "ServiceType", bill.ServiceID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "LastName", bill.EmployeeID);
            return View(bill);
        }

        // GET: Bills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bill bill = db.Bills.Find(id);
            if (bill == null)
            {
                return HttpNotFound();
            }
            ViewBag.MemberID = new SelectList(db.Members, "ID", "email", bill.MemberID);
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "ServiceType", bill.ServiceID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "LastName", bill.EmployeeID);
            return View(bill);
        }

        // POST: Bills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MemberID,ServiceID,Price,Status,EmployeeID")] Bill bill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MemberID = new SelectList(db.Members, "ID", "email", bill.MemberID);
            ViewBag.ServiceID = new SelectList(db.Services, "ID", "ServiceType", bill.ServiceID);
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "LastName", bill.EmployeeID);
            return View(bill);
        }

        // GET: Bills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bill bill = db.Bills.Find(id);
            if (bill == null)
            {
                return HttpNotFound();
            }
            return View(bill);
        }

        // POST: Bills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bill bill = db.Bills.Find(id);
            db.Bills.Remove(bill);
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
