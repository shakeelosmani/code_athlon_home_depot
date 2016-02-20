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
    public class RelatedQuestionAnswersController : Controller
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: RelatedQuestionAnswers
        public ActionResult Index()
        {
            return View(db.RelatedQuestionAnswer.ToList());
        }

        // GET: RelatedQuestionAnswers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedQuestionAnswer relatedQuestionAnswer = db.RelatedQuestionAnswer.Find(id);
            if (relatedQuestionAnswer == null)
            {
                return HttpNotFound();
            }
            return View(relatedQuestionAnswer);
        }

        // GET: RelatedQuestionAnswers/Create
        public ActionResult Create()
        {
            ViewBag.Questions = db.QuestionAndAnswers.ToList();
            return View();
        }

        // POST: RelatedQuestionAnswers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RelatedQuestionAnswerId,QuestionAndAnswerId,RelatedQuestionMessage")] RelatedQuestionAnswer relatedQuestionAnswer)
        {
            if (ModelState.IsValid)
            {
                var a = Request.Form["questionbox"];
                int l = a.IndexOf(" ");
                a = a.Substring(0, 1);
                relatedQuestionAnswer.QuestionAndAnswerId = Int32.Parse(a);
                db.RelatedQuestionAnswer.Add(relatedQuestionAnswer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatedQuestionAnswer);
        }

        // GET: RelatedQuestionAnswers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedQuestionAnswer relatedQuestionAnswer = db.RelatedQuestionAnswer.Find(id);
            if (relatedQuestionAnswer == null)
            {
                return HttpNotFound();
            }
            return View(relatedQuestionAnswer);
        }

        // POST: RelatedQuestionAnswers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RelatedQuestionAnswerId,QuestionAndAnswerId,RelatedQuestionMessage")] RelatedQuestionAnswer relatedQuestionAnswer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatedQuestionAnswer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatedQuestionAnswer);
        }

        // GET: RelatedQuestionAnswers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatedQuestionAnswer relatedQuestionAnswer = db.RelatedQuestionAnswer.Find(id);
            if (relatedQuestionAnswer == null)
            {
                return HttpNotFound();
            }
            return View(relatedQuestionAnswer);
        }

        // POST: RelatedQuestionAnswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RelatedQuestionAnswer relatedQuestionAnswer = db.RelatedQuestionAnswer.Find(id);
            db.RelatedQuestionAnswer.Remove(relatedQuestionAnswer);
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
