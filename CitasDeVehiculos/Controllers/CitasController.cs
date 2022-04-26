using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasDeVehiculos.Entidades;

namespace CitasDeVehiculos.Controllers
{
    
    [ApiController]
    [Route("api/citas")]
    public class CitasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public CitasController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Citas>>> Get()
        {
            return await context.Citas.Include(x => x.Estado).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Citas citas)
        {
            context.Add(citas);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")] // api/autores/1 
        public async Task<ActionResult> Put(Citas citas, int id)
        {
            if (citas.Id != id)
            {
                return BadRequest("El id de la cita no coincide con el id de la URL");
            }

            var existe = await context.Citas.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Update(citas);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")] // api/autores/2
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Citas.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound();
            }

            context.Remove(new Citas() { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }

    }
}
