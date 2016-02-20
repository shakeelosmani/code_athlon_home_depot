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
    public class QuestionAndAnswersController : Controller
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: QuestionAndAnswers
        public ActionResult Index()
        {
            var questionAndAnswers = db.QuestionAndAnswers.Include(q => q.AreaOfExpertise).Include(q => q.Pros);
            return View(questionAndAnswers.ToList());
        }

        // GET: QuestionAndAnswers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionAndAnswers questionAndAnswers = db.QuestionAndAnswers.Find(id);
            if (questionAndAnswers == null)
            {
                return HttpNotFound();
            }
            return View(questionAndAnswers);
        }

        // GET: QuestionAndAnswers/Create
        public ActionResult Create()
        {
            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName");
            ViewBag.ProsId = new SelectList(db.Pros, "ProsId", "FirstName");
            return View();
        }

        // POST: QuestionAndAnswers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestionAndAnswersId,ProsId,Question,Answer,AreaOfExpertiseId,UserRating,UserId")] QuestionAndAnswers questionAndAnswers)
        {
            if (ModelState.IsValid)
            {
                db.QuestionAndAnswers.Add(questionAndAnswers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName", questionAndAnswers.AreaOfExpertiseId);
            ViewBag.ProsId = new SelectList(db.Pros, "ProsId", "FirstName", questionAndAnswers.ProsId);
            return View(questionAndAnswers);
        }

        // GET: QuestionAndAnswers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionAndAnswers questionAndAnswers = db.QuestionAndAnswers.Find(id);
            if (questionAndAnswers == null)
            {
                return HttpNotFound();
            }
            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName", questionAndAnswers.AreaOfExpertiseId);
            ViewBag.ProsId = new SelectList(db.Pros, "ProsId", "FirstName", questionAndAnswers.ProsId);
            return View(questionAndAnswers);
        }

        // POST: QuestionAndAnswers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuestionAndAnswersId,ProsId,Question,Answer,AreaOfExpertiseId,UserRating,UserId")] QuestionAndAnswers questionAndAnswers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionAndAnswers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AreaOfExpertiseId = new SelectList(db.AreaOfExpertise, "AreaOfExpertiseId", "AreaOfExpertiseName", questionAndAnswers.AreaOfExpertiseId);
            ViewBag.ProsId = new SelectList(db.Pros, "ProsId", "FirstName", questionAndAnswers.ProsId);
            return View(questionAndAnswers);
        }

        // GET: QuestionAndAnswers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionAndAnswers questionAndAnswers = db.QuestionAndAnswers.Find(id);
            if (questionAndAnswers == null)
            {
                return HttpNotFound();
            }
            return View(questionAndAnswers);
        }

        // POST: QuestionAndAnswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuestionAndAnswers questionAndAnswers = db.QuestionAndAnswers.Find(id);
            db.QuestionAndAnswers.Remove(questionAndAnswers);
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
