using MikhunaAPI.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace MikhunaAPI.Controllers
{
    public class RecetasController : ApiController
    {
        private MikhunaDB db = new MikhunaDB();

        // GET: api/Recetas 
        public IQueryable<Recetas> GetRecetas()
        {
            return db.Recetas;
        }

        // GET: api/Recetas/5
        [ResponseType(typeof(Recetas))]
        public IHttpActionResult GetRecetas(int id)
        {
            Recetas recetas = db.Recetas.Find(id);
            if (recetas == null)
            {
                return NotFound();
            }

            return Ok(recetas);
        }

        // PUT: api/Recetas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRecetas(int id, Recetas recetas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != recetas.RecetaID)
            {
                return BadRequest();
            }

            db.Entry(recetas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecetasExists(id))
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

        // POST: api/Recetas
        [ResponseType(typeof(Recetas))]
        public IHttpActionResult PostRecetas(Recetas recetas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Recetas.Add(recetas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = recetas.RecetaID }, recetas);
        }

        // DELETE: api/Recetas/5
        [ResponseType(typeof(Recetas))]
        public IHttpActionResult DeleteReceta(int id)
        {
            Recetas recetas = db.Recetas.Find(id);
            if (recetas == null)
            {
                return NotFound();
            }

            db.Recetas.Remove(recetas);
            db.SaveChanges();

            return Ok(recetas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RecetasExists(int id)
        {
            return db.Recetas.Count(e => e.RecetaID == id) > 0;
        }
    }
}
