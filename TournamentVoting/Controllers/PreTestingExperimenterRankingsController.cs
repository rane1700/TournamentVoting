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
using TournamentVoting.Models;

namespace TournamentVoting.Controllers
{
    public class PreTestingExperimenterRankingsController : ApiController
    {
        private TournamentVotingContext db = new TournamentVotingContext();

        // GET: api/PreTestingExperimenterRankings
        public IQueryable<PreTestingExperimenterRanking> GetPreTestingExperimenterRankings()
        {
            //Serialize-able - return Json dbSet
            return db.PreTestingExperimenterRankings;
        }

        // GET: api/PreTestingExperimenterRankings/5
        //Response type means - if request succeded what is the type you are looking for ?
        [ResponseType(typeof(PreTestingExperimenterRanking))]
        public IHttpActionResult GetPreTestingExperimenterRanking(int id)
        {
            //Note: Find function searches database only according to key
            PreTestingExperimenterRanking preTestingExperimenterRanking = db.PreTestingExperimenterRankings.Find(id);
            if (preTestingExperimenterRanking == null)
            {
                return NotFound();
            }

            return Ok(preTestingExperimenterRanking);
        }

        // PUT: api/PreTestingExperimenterRankings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPreTestingExperimenterRanking(int id, PreTestingExperimenterRanking preTestingExperimenterRanking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != preTestingExperimenterRanking.Id)
            {
                return BadRequest();
            }

            db.Entry(preTestingExperimenterRanking).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreTestingExperimenterRankingExists(id))
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

        // POST: api/PreTestingExperimenterRankings
        [ResponseType(typeof(PreTestingExperimenterRanking))]
        public IHttpActionResult PostPreTestingExperimenterRanking(PreTestingExperimenterRanking preTestingExperimenterRanking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PreTestingExperimenterRankings.Add(preTestingExperimenterRanking);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = preTestingExperimenterRanking.Id }, preTestingExperimenterRanking);
        }

        // DELETE: api/PreTestingExperimenterRankings/5
        [ResponseType(typeof(PreTestingExperimenterRanking))]
        public IHttpActionResult DeletePreTestingExperimenterRanking(int id)
        {
            PreTestingExperimenterRanking preTestingExperimenterRanking = db.PreTestingExperimenterRankings.Find(id);
            if (preTestingExperimenterRanking == null)
            {
                return NotFound();
            }

            db.PreTestingExperimenterRankings.Remove(preTestingExperimenterRanking);
            db.SaveChanges();

            return Ok(preTestingExperimenterRanking);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PreTestingExperimenterRankingExists(int id)
        {
            return db.PreTestingExperimenterRankings.Count(e => e.Id == id) > 0;
        }
    }
}