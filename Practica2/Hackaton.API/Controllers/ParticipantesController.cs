using Hackaton.API.Data;
using Hackaton.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/participantes")]
    public class ParticipantesController:ControllerBase
    {
        private readonly DataContext _context;
        public ParticipantesController(DataContext context)
        {
            _context = context;
        }


        //GET POR LISTA 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Participantes.ToArrayAsync());
        }


        //PUT --> MODIFICAR UN PARTICIPANTE
        [HttpPut]
        public async Task<ActionResult> Put(Participante participante)
        {
            _context.Update(participante);
            await _context.SaveChangesAsync();
            return Ok(participante); //Para que muestre que valor modificado

        }

        //DELETE --> BORRAR UN PARTICIPANTE
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

        //GET POR PARAMETRO 
        [HttpGet("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Get(int id) 
        {
            var participante = await _context.Participantes.FirstOrDefaultAsync(x => x.Id == id);
            if (participante == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(participante);
            }
        }


        //POST --> INSERTAR NUEVO PARTICIPANTE
        [HttpPost]
        public async Task<ActionResult> Post(Participante participante)
        {
            _context.Add(participante);
            await _context.SaveChangesAsync();
            return Ok(participante); 

        }
    }
}
