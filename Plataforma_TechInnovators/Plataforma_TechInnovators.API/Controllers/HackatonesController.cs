using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma_TechInnovators.API.Data;
using Plataforma_TechInnovators.Shared.Entities;

namespace Plataforma_TechInnovators.API.Controllers
{
    [ApiController]
    [Route("/api/hackaton")]
    public class HackatonesController: ControllerBase
    {
        private readonly DataContext _context;
        public HackatonesController(DataContext context)
        {

            _context = context;
            
        }

        //Get con lista 

        //Select * From Hackaton 



        [HttpGet]

        public async Task<ActionResult> Get()

        {
            return Ok(await _context.Hackatones.ToListAsync());
        }



        // Get por parámetro 

        [HttpGet("{id:int}")]

        public async Task<ActionResult> Get(int id)

        {
            //200 Ok 
            var hackaton = await _context.Hackatones.FirstOrDefaultAsync(x => x.Id == id);

            if (hackaton == null)

            {
                return NotFound();
            }
            return Ok(hackaton);
        }


        [HttpPost]

        public async Task<ActionResult> Post(Hackaton hackaton)

        {

            _context.Add(hackaton);

            await _context.SaveChangesAsync();

            return Ok(hackaton);

        }

        //DELETE --> BORRAR UN EQUIPO
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Hackatones
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
