using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Jabil.Models;

namespace Jabil.Controllers
{
    public class PartNumbersController : Controller
    {
        private JabilModel db = new JabilModel();

        // GET: PartNumbers
        public ActionResult Index()
        {
            var partNumbers = db.PartNumbers.Include(p => p.Customer);
            return View(partNumbers.ToList());
        }

        // GET: PartNumbers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartNumber partNumber = db.PartNumbers.Find(id);
            if (partNumber == null)
            {
                return HttpNotFound();
            }
            return View(partNumber);
        }

        // GET: PartNumbers/Create
        public ActionResult Create()
        {
            ViewBag.FKCustomer = new SelectList(db.Buildings, "PKBuilding", "Building1");
            return View();
        }

        // POST: PartNumbers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PKPartNumber,PartNumber1,FKCustomer,Available")] PartNumber partNumber)
        {
            if (ModelState.IsValid)
            {
                db.PartNumbers.Add(partNumber);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKCustomer = new SelectList(db.Buildings, "PKBuilding", "Building1", partNumber.FKCustomer);
            return View(partNumber);
        }

        // GET: PartNumbers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartNumber partNumber = db.PartNumbers.Find(id);
            if (partNumber == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKCustomer = new SelectList(db.Buildings, "PKBuilding", "Building1", partNumber.FKCustomer);
            return View(partNumber);
        }

        // POST: PartNumbers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PKPartNumber,PartNumber1,FKCustomer,Available")] PartNumber partNumber)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partNumber).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKCustomer = new SelectList(db.Buildings, "PKBuilding", "Building1", partNumber.FKCustomer);
            return View(partNumber);
        }

        // GET: PartNumbers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PartNumber partNumber = db.PartNumbers.Find(id);
            if (partNumber == null)
            {
                return HttpNotFound();
            }
            return View(partNumber);
        }

        // POST: PartNumbers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PartNumber partNumber = db.PartNumbers.Find(id);
            db.PartNumbers.Remove(partNumber);
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
