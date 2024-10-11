using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma_TechInnovators.API.Data;
using Plataforma_TechInnovators.Shared.Entities;

namespace Plataforma_TechInnovators.API.Controllers
{
    [ApiController]

        [Route("/api/mentores")]

        public class MentoresController : ControllerBase

        {
            private readonly DataContext _context;

            public MentoresController(DataContext context)

            {
                _context = context;
            }


        //Get con lista 

        //Select * From mentores 

        [HttpGet]

            public async Task<ActionResult> Get()

            {
                return Ok(await _context.Mentores.ToListAsync());
            }


            // Get por parámetro 

            [HttpGet("{id:int}")]

            public async Task<ActionResult> Get(int id)
            {
                //200 Ok 
                var mentor = await _context.Mentores.FirstOrDefaultAsync(x => x.Id == id);
                if (mentor == null)

                {
                    return NotFound();
                }
                return Ok(mentor);
            }


            [HttpPost]

            public async Task<ActionResult> Post(Mentor mentor)

            {
                _context.Add(mentor);

                await _context.SaveChangesAsync();

                return Ok(mentor);
            }


        // Put: Modificar
        [HttpPut]
        public async Task<ActionResult> Put(Mentor mentor)
        {
            _context.Update(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor);
        }


        //DELETE --> BORRAR UN EQUIPO
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Mentores
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
