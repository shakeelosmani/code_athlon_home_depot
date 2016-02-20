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
    public class ProsController : ApiController
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: api/Pros
        public IQueryable<Pros> GetPros()
        {
            return db.Pros;
        }

        // GET: api/Pros/5
        [ResponseType(typeof(Pros))]
        public IHttpActionResult GetPros(int id)
        {
            Pros pros = db.Pros.Find(id);
            if (pros == null)
            {
                return NotFound();
            }

            return Ok(pros);
        }

        // PUT: api/Pros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPros(int id, Pros pros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pros.ProsId)
            {
                return BadRequest();
            }

            db.Entry(pros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProsExists(id))
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

        // POST: api/Pros
        [ResponseType(typeof(Pros))]
        public IHttpActionResult PostPros(Pros pros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pros.Add(pros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pros.ProsId }, pros);
        }

        // DELETE: api/Pros/5
        [ResponseType(typeof(Pros))]
        public IHttpActionResult DeletePros(int id)
        {
            Pros pros = db.Pros.Find(id);
            if (pros == null)
            {
                return NotFound();
            }

            db.Pros.Remove(pros);
            db.SaveChanges();

            return Ok(pros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProsExists(int id)
        {
            return db.Pros.Count(e => e.ProsId == id) > 0;
        }
    }
}