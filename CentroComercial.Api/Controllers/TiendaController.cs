using CentroComercial.API.Data;
using CentroComercial.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CentroComercial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class TiendaController : ControllerBase
    {


        private readonly DataContext _context;

        public TiendaController(DataContext context)
        {
            _context = context;
        }

        //Get con lista
        //Select * From Tiendas

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Tiendas.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var tienda = await _context.Tiendas.FirstOrDefaultAsync(x => x.IdTienda == id);

            if (tienda == null)
            {


                return NotFound();
            }

            return Ok(tienda);


        }

        // Crear un nuevo registro
        [HttpPost]
        public async Task<ActionResult> Post(Tienda Tienda)
        {
            _context.Add(Tienda);
            await _context.SaveChangesAsync();
            return Ok(Tienda);
        }

        // Actualizar o cambiar registro

        [HttpPut]
        public async Task<ActionResult> Put(Tienda Tienda)
        {
            _context.Update(Tienda);
            await _context.SaveChangesAsync();
            return Ok(Tienda);
        }

        // ELiminar registros

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilaAfectada = await _context.Tiendas
                .Where(x => x.IdTienda == id)//5
                .ExecuteDeleteAsync();

            if (FilaAfectada == 0)
            {


                return NotFound();//404
            }

            return NoContent();//204


        }
    }
}
