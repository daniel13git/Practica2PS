using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma_TechInnovators.API.Data;
using Plataforma_TechInnovators.Shared.Entities;

namespace Plataforma_TechInnovators.API.Controllers
{
    [ApiController]

    [Route("/api/evaluaciones")]

    public class EvaluacionesController : ControllerBase

    {
        private readonly DataContext _context;

        public EvaluacionesController(DataContext context)

        {
            _context = context;
        }


        //Get con lista 

        //Select * From owners 

        [HttpGet]

        public async Task<ActionResult> Get()

        {
            return Ok(await _context.Evaluaciones.ToListAsync());
        }



        // Get por parámetro 

        [HttpGet("{id:int}")]

        public async Task<ActionResult> Get(int id)

        {
            //200 Ok 

            var evaluacion = await _context.Evaluaciones.FirstOrDefaultAsync(x => x.Id == id);

            if (evaluacion == null)

            {
                return NotFound();
            }
            return Ok(evaluacion);
        }

        [HttpPost]

        public async Task<ActionResult> Post(Evaluacion evaluacion)

        {
            _context.Add(evaluacion);

            await _context.SaveChangesAsync();

            return Ok(evaluacion);
        }

        //DELETE --> BORRAR UN EQUIPO
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Evaluaciones
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
