using CentroComercial.API.Data;
using CentroComercial.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CentroComercial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CComercialController : ControllerBase
    {
        private readonly DataContext _context;

        public CComercialController(DataContext context)
        {
            _context = context;
        }

        //Get con lista
        //Select * From Tiendas

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.CentrosComerciales.ToListAsync());


        }

        // Get por parámetro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            //200 Ok

            var centrocomercial = await _context.CentrosComerciales.FirstOrDefaultAsync(x => x.IdCentroComercial == id);

            if (centrocomercial == null)
            {


                return NotFound();
            }

            return Ok(centrocomercial);


        }

        // Crear un nuevo registro
        [HttpPost]
        public async Task<ActionResult> Post(CComercial cComercial)
        {
            _context.Add(cComercial);
            await _context.SaveChangesAsync();
            return Ok(cComercial);
        }

        // Actualizar o cambiar registro

        [HttpPut]
        public async Task<ActionResult> Put(CComercial cComercial)
        {
            _context.Update(cComercial);
            await _context.SaveChangesAsync();
            return Ok(cComercial);
        }

        // ELiminar registros

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {


            var FilaAfectada = await _context.CentrosComerciales
                .Where(x => x.IdCentroComercial == id)//5
                .ExecuteDeleteAsync();

            if (FilaAfectada == 0)
            {


                return NotFound();//404
            }

            return NoContent();//204


        }
    }
}
