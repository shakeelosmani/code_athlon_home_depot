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
    public class LeaderBoardsController : ApiController
    {
        private HomeDepotProConnectContext db = new HomeDepotProConnectContext();

        // GET: api/LeaderBoards
        public IQueryable<LeaderBoard> GetLeaderBoard()
        {
            return db.LeaderBoard;
        }

        // GET: api/LeaderBoards/5
        [ResponseType(typeof(LeaderBoard))]
        public IHttpActionResult GetLeaderBoard(int id)
        {
            LeaderBoard leaderBoard = db.LeaderBoard.Find(id);
            if (leaderBoard == null)
            {
                return NotFound();
            }

            return Ok(leaderBoard);
        }

        // PUT: api/LeaderBoards/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLeaderBoard(int id, LeaderBoard leaderBoard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != leaderBoard.LeaderBoardId)
            {
                return BadRequest();
            }

            db.Entry(leaderBoard).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaderBoardExists(id))
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

        // POST: api/LeaderBoards
        [ResponseType(typeof(LeaderBoard))]
        public IHttpActionResult PostLeaderBoard(LeaderBoard leaderBoard)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LeaderBoard.Add(leaderBoard);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = leaderBoard.LeaderBoardId }, leaderBoard);
        }

        // DELETE: api/LeaderBoards/5
        [ResponseType(typeof(LeaderBoard))]
        public IHttpActionResult DeleteLeaderBoard(int id)
        {
            LeaderBoard leaderBoard = db.LeaderBoard.Find(id);
            if (leaderBoard == null)
            {
                return NotFound();
            }

            db.LeaderBoard.Remove(leaderBoard);
            db.SaveChanges();

            return Ok(leaderBoard);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LeaderBoardExists(int id)
        {
            return db.LeaderBoard.Count(e => e.LeaderBoardId == id) > 0;
        }
    }
}