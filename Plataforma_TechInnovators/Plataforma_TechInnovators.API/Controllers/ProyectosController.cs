using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma_TechInnovators.API.Data;
using Plataforma_TechInnovators.Shared.Entities;

namespace Plataforma_TechInnovators.API.Controllers
{
    [ApiController]

    [Route("/api/proyectos")]

    public class ProyectosController : ControllerBase

    {
        private readonly DataContext _context;

        public ProyectosController(DataContext context)

        {
            _context = context;
        }


        //Get con lista 

        //Select * From mentores 

        [HttpGet]

        public async Task<ActionResult> Get()

        {
            return Ok(await _context.Proyectos.ToListAsync());
        }



        // Get por parámetro 

        [HttpGet("{id:int}")]

        public async Task<ActionResult> Get(int id)

        {
            //200 Ok 

            var proyecto = await _context.Proyectos.FirstOrDefaultAsync(x => x.Id == id);

            if (proyecto == null)

            {
                return NotFound();
            }
            return Ok(proyecto);
        }

        [HttpPost]

        public async Task<ActionResult> Post(Proyecto proyecto)

        {
            _context.Add(proyecto);

            await _context.SaveChangesAsync();

            return Ok(proyecto);
        }

        //DELETE --> BORRAR UN EQUIPO
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Proyectos
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();


            if (FilasAfectadas == 0)
            {
                return NotFound();
            }
            else
            {
                return NoContent(); //204
            }
        }
    }
}
