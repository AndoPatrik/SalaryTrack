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
using SalaryTrackWebService.Models;


namespace SalaryTrackWebService.Controllers
{
    public class RecordsController : ApiController
    {
        private SalaryTrackWebServiceContext db = new SalaryTrackWebServiceContext();

        // GET: api/Records
        public IQueryable<Records> GetRecords()
        {
            return db.Records;
        }

        // GET: api/Records/5
        [ResponseType(typeof(Records))]
        public IHttpActionResult GetRecords(int id)
        {
            Records records = db.Records.Find(id);
            if (records == null)
            {
                return NotFound();
            }

            return Ok(records);
        }

        // PUT: api/Records/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRecords(int id, Records records)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != records.RecordID)
            {
                return BadRequest();
            }

            db.Entry(records).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecordsExists(id))
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

        // POST: api/Records
        [ResponseType(typeof(Records))]
        public IHttpActionResult PostRecords(Records records)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Records.Add(records);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RecordsExists(records.RecordID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = records.RecordID }, records);
        }

        // DELETE: api/Records/5
        [ResponseType(typeof(Records))]
        public IHttpActionResult DeleteRecords(int id)
        {
            Records records = db.Records.Find(id);
            if (records == null)
            {
                return NotFound();
            }

            db.Records.Remove(records);
            db.SaveChanges();

            return Ok(records);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RecordsExists(int id)
        {
            return db.Records.Count(e => e.RecordID == id) > 0;
        }
    }
}