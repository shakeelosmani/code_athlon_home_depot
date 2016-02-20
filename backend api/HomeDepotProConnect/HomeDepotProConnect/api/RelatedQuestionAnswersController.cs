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
    public class RelatedQuestionAnswersController : ApiController
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: api/RelatedQuestionAnswers
        public IQueryable<RelatedQuestionAnswer> GetRelatedQuestionAnswer()
        {
            return db.RelatedQuestionAnswer;
        }

        // GET: api/RelatedQuestionAnswers/5
        [ResponseType(typeof(RelatedQuestionAnswer))]
        public IHttpActionResult GetRelatedQuestionAnswer(int id)
        {
            RelatedQuestionAnswer relatedQuestionAnswer = db.RelatedQuestionAnswer.Find(id);
            if (relatedQuestionAnswer == null)
            {
                return NotFound();
            }

            return Ok(relatedQuestionAnswer);
        }

        // PUT: api/RelatedQuestionAnswers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRelatedQuestionAnswer(int id, RelatedQuestionAnswer relatedQuestionAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != relatedQuestionAnswer.RelatedQuestionAnswerId)
            {
                return BadRequest();
            }

            db.Entry(relatedQuestionAnswer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RelatedQuestionAnswerExists(id))
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

        // POST: api/RelatedQuestionAnswers
        [ResponseType(typeof(RelatedQuestionAnswer))]
        public IHttpActionResult PostRelatedQuestionAnswer(RelatedQuestionAnswer relatedQuestionAnswer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RelatedQuestionAnswer.Add(relatedQuestionAnswer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = relatedQuestionAnswer.RelatedQuestionAnswerId }, relatedQuestionAnswer);
        }

        // DELETE: api/RelatedQuestionAnswers/5
        [ResponseType(typeof(RelatedQuestionAnswer))]
        public IHttpActionResult DeleteRelatedQuestionAnswer(int id)
        {
            RelatedQuestionAnswer relatedQuestionAnswer = db.RelatedQuestionAnswer.Find(id);
            if (relatedQuestionAnswer == null)
            {
                return NotFound();
            }

            db.RelatedQuestionAnswer.Remove(relatedQuestionAnswer);
            db.SaveChanges();

            return Ok(relatedQuestionAnswer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RelatedQuestionAnswerExists(int id)
        {
            return db.RelatedQuestionAnswer.Count(e => e.RelatedQuestionAnswerId == id) > 0;
        }
    }
}