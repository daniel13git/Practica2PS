using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma_TechInnovators.API.Data;
using Plataforma_TechInnovators.Shared.Entities;

namespace Plataforma_TechInnovators.API.Controllers
{
    [ApiController]

    [Route("/api/participantes")]

    public class ParticipantesController : ControllerBase

    {
        private readonly DataContext _context;

        public ParticipantesController(DataContext context)

        {
            _context = context;
        }


        //Get con lista 

        //Select * From mentores 

        [HttpGet]

        public async Task<ActionResult> Get()

        {
            return Ok(await _context.Participantes.ToListAsync());
        }



        // Get por parámetro 

        [HttpGet("{id:int}")]

        public async Task<ActionResult> Get(int id)

        {
            //200 Ok 

            var participante = await _context.Participantes.FirstOrDefaultAsync(x => x.Id == id);

            if (participante == null)

            {
                return NotFound();
            }
            return Ok(participante);
        }

        [HttpPost]

        public async Task<ActionResult> Post(Participante participante)

        {
            _context.Add(participante);

            await _context.SaveChangesAsync();

            return Ok(participante);
        }


        // Put: Modificar
        [HttpPut]
        public async Task<ActionResult> Put(Participante participante)
        {
            _context.Update(participante);
            await _context.SaveChangesAsync();
            return Ok(participante);
        }


        //DELETE --> BORRAR UN EQUIPO
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Participantes
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
