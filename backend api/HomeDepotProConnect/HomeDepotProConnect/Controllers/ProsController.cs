using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeDepotProConnect.DAL;
using HomeDepotProConnect.Models;

namespace HomeDepotProConnect.Controllers
{
    public class ProsController : Controller
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: Pros
        public ActionResult Index()
        {
            var pros = db.Pros.Include(p => p.AreaOfExpertise);
            return View(pros.ToList());
        }

        // GET: Pros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pros pros = db.Pros.Find(id);
            if (pros == null)
            {
                return HttpNotFound();
            }
            return View(pros);
        }

        // GET: Pros/Create
        public ActionResult Create()
        {
            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName");
            return View();
        }

        // POST: Pros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProsId,FirstName,LastName,Email,DeviceId,AdditionalDeviceId,AnswerStartHours,AnswerEndHours,AreaOfExpertiseId")] Pros pros)
        {
            if (ModelState.IsValid)
            {
                db.Pros.Add(pros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName", pros.AreaOfExpertiseId);
            return View(pros);
        }

        // GET: Pros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pros pros = db.Pros.Find(id);
            if (pros == null)
            {
                return HttpNotFound();
            }
            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName", pros.AreaOfExpertiseId);
            return View(pros);
        }

        // POST: Pros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProsId,FirstName,LastName,Email,DeviceId,AdditionalDeviceId,AnswerStartHours,AnswerEndHours,AreaOfExpertiseId")] Pros pros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName", pros.AreaOfExpertiseId);
            return View(pros);
        }

        // GET: Pros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pros pros = db.Pros.Find(id);
            if (pros == null)
            {
                return HttpNotFound();
            }
            return View(pros);
        }

        // POST: Pros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pros pros = db.Pros.Find(id);
            db.Pros.Remove(pros);
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
