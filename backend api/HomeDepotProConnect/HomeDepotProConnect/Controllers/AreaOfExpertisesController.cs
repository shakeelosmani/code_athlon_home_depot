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
    public class AreaOfExpertisesController : Controller
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: AreaOfExpertises
        public ActionResult Index()
        {
            return View(db.AreaOfExpertise.ToList());
        }

        // GET: AreaOfExpertises/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AreaOfExpertise areaOfExpertise = db.AreaOfExpertise.Find(id);
            if (areaOfExpertise == null)
            {
                return HttpNotFound();
            }
            return View(areaOfExpertise);
        }

        // GET: AreaOfExpertises/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AreaOfExpertises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AreaOfExpertiseId,AreaOfExpertiseName,AreaOfExpertiseDescription")] AreaOfExpertise areaOfExpertise)
        {
            if (ModelState.IsValid)
            {
                db.AreaOfExpertise.Add(areaOfExpertise);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(areaOfExpertise);
        }

        // GET: AreaOfExpertises/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AreaOfExpertise areaOfExpertise = db.AreaOfExpertise.Find(id);
            if (areaOfExpertise == null)
            {
                return HttpNotFound();
            }
            return View(areaOfExpertise);
        }

        // POST: AreaOfExpertises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AreaOfExpertiseId,AreaOfExpertiseName,AreaOfExpertiseDescription")] AreaOfExpertise areaOfExpertise)
        {
            if (ModelState.IsValid)
            {
                db.Entry(areaOfExpertise).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(areaOfExpertise);
        }

        // GET: AreaOfExpertises/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AreaOfExpertise areaOfExpertise = db.AreaOfExpertise.Find(id);
            if (areaOfExpertise == null)
            {
                return HttpNotFound();
            }
            return View(areaOfExpertise);
        }

        // POST: AreaOfExpertises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AreaOfExpertise areaOfExpertise = db.AreaOfExpertise.Find(id);
            db.AreaOfExpertise.Remove(areaOfExpertise);
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
