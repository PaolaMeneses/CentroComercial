using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CentroComercial.API.Data;
using CentroComercial.Shared.Entities;

namespace CentroComercial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacionController : ControllerBase
    {
        private readonly DataContext _context;

        public NotificacionController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Notificacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Notificacion>>> Get()
        {
            var notificaciones = await _context.Notificaciones.ToListAsync();
            return Ok(notificaciones);
        }

        // GET: api/Notificacion/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Notificacion>> Get(int id)
        {
            var notificacion = await _context.Notificaciones.FirstOrDefaultAsync(x => x.Id == id);

            if (notificacion == null)
            {
                return NotFound();
            }

            return Ok(notificacion);
        }

        // POST: api/Notificacion
        [HttpPost]
        public async Task<ActionResult<Notificacion>> Post(Notificacion notificacion)
        {
            _context.Notificaciones.Add(notificacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = notificacion.Id }, notificacion);
        }

        // PUT: api/Notificacion
        [HttpPut]
        public async Task<ActionResult<Notificacion>> Put(Notificacion notificacion)
        {
            _context.Entry(notificacion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(notificacion);
        }

        // DELETE: api/Notificacion/5
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var notificacion = await _context.Notificaciones.FirstOrDefaultAsync(x => x.Id == id);

            if (notificacion == null)
            {
                return NotFound();
            }

            _context.Notificaciones.Remove(notificacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

