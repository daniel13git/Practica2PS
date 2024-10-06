using Hackaton.API.Data;
using Hackaton.Shared.Entities;
using Hackaton.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{

    [ApiController]
    [Route("/api/evaluaciones")]
    public class EvaluacionesController: ControllerBase
    {
        private readonly DataContext _context;
        public EvaluacionesController(DataContext context)
        {
            _context = context;
        }

        //GET POR LISTA 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Evaluaciones.ToArrayAsync());
        }


        //PUT --> MODIFICAR UN EQUIPO
        [HttpPut]
        public async Task<ActionResult> Put(Evaluacion evaluacion)
        {
            _context.Update(evaluacion);
            await _context.SaveChangesAsync();
            return Ok(evaluacion); //Para que muestre que valor modificado

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

        //GET POR PARAMETRO 
        [HttpGet("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Get(int id)
        {
            var evaluacion = await _context.Evaluaciones.FirstOrDefaultAsync(x => x.Id == id);
            if (evaluacion == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(evaluacion);
            }
        }


        //POST --> INSERTAR NUEVO PARTICIPANTE
        [HttpPost]
        public async Task<ActionResult> Post(Evaluacion evaluacion)
        {
            _context.Add(evaluacion);
            await _context.SaveChangesAsync();
            return Ok(evaluacion);

        }


    }

}

