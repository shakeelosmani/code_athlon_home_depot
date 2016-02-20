using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HomeDepotProConnect.DAL;
using HomeDepotProConnect.Models;

namespace HomeDepotProConnect.api
{
    public class QuestionAndAnswersController : ApiController
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: api/QuestionAndAnswers
        public IQueryable<QuestionAndAnswers> GetQuestionAndAnswers()
        {
            return db.QuestionAndAnswers;
        }

        // GET: api/QuestionAndAnswers/5
        [ResponseType(typeof(QuestionAndAnswers))]
        public IHttpActionResult GetQuestionAndAnswers(int id)
        {
            QuestionAndAnswers questionAndAnswers = db.QuestionAndAnswers.Find(id);
            if (questionAndAnswers == null)
            {
                return NotFound();
            }

            return Ok(questionAndAnswers);
        }

        // PUT: api/QuestionAndAnswers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQuestionAndAnswers(int id, QuestionAndAnswers questionAndAnswers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != questionAndAnswers.QuestionAndAnswersId)
            {
                return BadRequest();
            }

            db.Entry(questionAndAnswers).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionAndAnswersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/QuestionAndAnswers
        [ResponseType(typeof(QuestionAndAnswers))]
        public IHttpActionResult PostQuestionAndAnswers(QuestionAndAnswers questionAndAnswers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.QuestionAndAnswers.Add(questionAndAnswers);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = questionAndAnswers.QuestionAndAnswersId }, questionAndAnswers);
        }

        // DELETE: api/QuestionAndAnswers/5
        [ResponseType(typeof(QuestionAndAnswers))]
        public IHttpActionResult DeleteQuestionAndAnswers(int id)
        {
            QuestionAndAnswers questionAndAnswers = db.QuestionAndAnswers.Find(id);
            if (questionAndAnswers == null)
            {
                return NotFound();
            }

            db.QuestionAndAnswers.Remove(questionAndAnswers);
            db.SaveChanges();

            return Ok(questionAndAnswers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuestionAndAnswersExists(int id)
        {
            return db.QuestionAndAnswers.Count(e => e.QuestionAndAnswersId == id) > 0;
        }
    }
}