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
    public class AreaOfExpertisesController : ApiController
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: api/AreaOfExpertises
        public IQueryable<AreaOfExpertise> GetAreaOfExpertise()
        {
            return db.AreaOfExpertise;
        }

        // GET: api/AreaOfExpertises/5
        [ResponseType(typeof(AreaOfExpertise))]
        public IHttpActionResult GetAreaOfExpertise(int id)
        {
            AreaOfExpertise areaOfExpertise = db.AreaOfExpertise.Find(id);
            if (areaOfExpertise == null)
            {
                return NotFound();
            }

            return Ok(areaOfExpertise);
        }

        // PUT: api/AreaOfExpertises/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAreaOfExpertise(int id, AreaOfExpertise areaOfExpertise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != areaOfExpertise.AreaOfExpertiseId)
            {
                return BadRequest();
            }

            db.Entry(areaOfExpertise).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaOfExpertiseExists(id))
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

        // POST: api/AreaOfExpertises
        [ResponseType(typeof(AreaOfExpertise))]
        public IHttpActionResult PostAreaOfExpertise(AreaOfExpertise areaOfExpertise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AreaOfExpertise.Add(areaOfExpertise);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = areaOfExpertise.AreaOfExpertiseId }, areaOfExpertise);
        }

        // DELETE: api/AreaOfExpertises/5
        [ResponseType(typeof(AreaOfExpertise))]
        public IHttpActionResult DeleteAreaOfExpertise(int id)
        {
            AreaOfExpertise areaOfExpertise = db.AreaOfExpertise.Find(id);
            if (areaOfExpertise == null)
            {
                return NotFound();
            }

            db.AreaOfExpertise.Remove(areaOfExpertise);
            db.SaveChanges();

            return Ok(areaOfExpertise);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AreaOfExpertiseExists(int id)
        {
            return db.AreaOfExpertise.Count(e => e.AreaOfExpertiseId == id) > 0;
        }
    }
}