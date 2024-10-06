using Hackaton.API.Data;
using Hackaton.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{

    [ApiController]
    [Route("/api/eventos")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }


        //GET POR LISTA 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Eventos.ToArrayAsync());
        }


        //PUT --> MODIFICAR UN Hackaton
        [HttpPut]
        public async Task<ActionResult> Put(EventosController eventos)
        {
            _context.Update(eventos);
            await _context.SaveChangesAsync();
            return Ok(eventos); //Para que muestre que valor modificado

        }

        //DELETE --> BORRAR UN MENTOR
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Eventos
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
            var eventos = await _context.Eventos.FirstOrDefaultAsync(x => x.Id == id);
            if (eventos == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(eventos);
            }
        }


        //POST --> INSERTAR NUEVO MENTOR
        [HttpPost]
        public async Task<ActionResult> Post(EventosController eventos)
        {
            _context.Add(eventos);
            await _context.SaveChangesAsync();
            return Ok(eventos);

        }
    }
}
