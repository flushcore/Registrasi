using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RegisterAPI.Models;

namespace RegisterAPI.Controllers
{
    public class RegisterController : ApiController
    {
        private DB_TestEntities1 db = new DB_TestEntities1();

        // GET: api/Register
        public IQueryable<tblM_User_data> GettblM_User_data()
        {
            return db.tblM_User_data;
        }

        // GET: api/Register/5
        [ResponseType(typeof(tblM_User_data))]
        public IHttpActionResult GettblM_User_data(int id)
        {
            tblM_User_data tblM_User_data = db.tblM_User_data.Find(id);
            if (tblM_User_data == null)
            {
                return NotFound();
            }

            return Ok(tblM_User_data);
        }

        // PUT: api/Register/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblM_User_data(int id, tblM_User_data tblM_User_data)
        {
            if (id != tblM_User_data.UserId)
            {
                return BadRequest();
            }

            db.Entry(tblM_User_data).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblM_User_dataExists(id))
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

        // POST: api/Register
        [ResponseType(typeof(tblM_User_data))]
        public IHttpActionResult PosttblM_User_data(tblM_User_data tblM_User_data)
        {
            db.tblM_User_data.Add(tblM_User_data);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblM_User_data.UserId }, tblM_User_data);
        }

        // DELETE: api/Register/5
        [ResponseType(typeof(tblM_User_data))]
        public IHttpActionResult DeletetblM_User_data(int id)
        {
            tblM_User_data tblM_User_data = db.tblM_User_data.Find(id);
            if (tblM_User_data == null)
            {
                return NotFound();
            }

            db.tblM_User_data.Remove(tblM_User_data);
            db.SaveChanges();

            return Ok(tblM_User_data);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblM_User_dataExists(int id)
        {
            return db.tblM_User_data.Count(e => e.UserId == id) > 0;
        }
    }
}