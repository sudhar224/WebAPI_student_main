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
using WebAPI_student.Models;

namespace WebAPI_student.Controllers
{
    public class tbl_student_marksController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/tbl_student_marks
        public IQueryable<tbl_student_marks> Gettbl_student_marks()
        {
            return db.tbl_student_marks;
        }

        // GET: api/tbl_student_marks/5
        [ResponseType(typeof(tbl_student_marks))]
        public IHttpActionResult Gettbl_student_marks(int id)
        {
            tbl_student_marks tbl_student_marks = db.tbl_student_marks.Find(id);
            if (tbl_student_marks == null)
            {
                return NotFound();
            }

            return Ok(tbl_student_marks);
        }

        // PUT: api/tbl_student_marks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_student_marks(int id, tbl_student_marks tbl_student_marks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_student_marks.id)
            {
                return BadRequest();
            }

            db.Entry(tbl_student_marks).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_student_marksExists(id))
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

        // POST: api/tbl_student_marks
        [ResponseType(typeof(tbl_student_marks))]
        public IHttpActionResult Posttbl_student_marks(tbl_student_marks tbl_student_marks)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tbl_student_marks.Add(tbl_student_marks);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tbl_student_marks.id }, tbl_student_marks);
        }

        // DELETE: api/tbl_student_marks/5
        [ResponseType(typeof(tbl_student_marks))]
        public IHttpActionResult Deletetbl_student_marks(int id)
        {
            tbl_student_marks tbl_student_marks = db.tbl_student_marks.Find(id);
            if (tbl_student_marks == null)
            {
                return NotFound();
            }

            db.tbl_student_marks.Remove(tbl_student_marks);
            db.SaveChanges();

            return Ok(tbl_student_marks);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_student_marksExists(int id)
        {
            return db.tbl_student_marks.Count(e => e.id == id) > 0;
        }
    }
}