using Hackaton.API.Data;
using Hackaton.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{

    [ApiController]
    [Route("/api/hackatons")]
    public class HackatonsController : ControllerBase
    {
        private readonly DataContext _context;
        public HackatonsController(DataContext context)
        {
            _context = context;
        }


        //GET POR LISTA 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Hackatons.ToArrayAsync());
        }


        //PUT --> MODIFICAR UN Hackaton
        [HttpPut]
        public async Task<ActionResult> Put(HackatonsController hackaton)
        {
            _context.Update(hackaton);
            await _context.SaveChangesAsync();
            return Ok(hackaton); //Para que muestre que valor modificado

        }

        //DELETE --> BORRAR UN MENTOR
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.HackatonController
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
            var hackaton = await _context.Hackatons.FirstOrDefaultAsync(x => x.Id == id);
            if (hackaton == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(hackaton);
            }
        }


        //POST --> INSERTAR NUEVO MENTOR
        [HttpPost]
        public async Task<ActionResult> Post(HackatonsController hackaton)
        {
            _context.Add(hackaton);
            await _context.SaveChangesAsync();
            return Ok(hackaton);

        }
    }
}
