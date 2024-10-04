using Hackaton.API.Data;
using Hackaton.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/mentores")]
    public class MentoresCrontoller : ControllerBase
    {
        private readonly DataContext _context;
        public MentoresCrontoller(DataContext context)
        {
            _context = context;
        }

        //GET POR LISTA 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Mentores.ToArrayAsync());
        }


        //PUT --> MODIFICAR UN MENTOR
        [HttpPut]
        public async Task<ActionResult> Put(Mentor mentor)
        {
            _context.Update(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor); //Para que muestre que valor modificado

        }

        //DELETE --> BORRAR UN MENTOR
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

        //GET POR PARAMETRO 
        [HttpGet("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Get(int id)
        {
            var mentor = await _context.Mentores.FirstOrDefaultAsync(x => x.Id == id);
            if (mentor == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mentor);
            }
        }


        //POST --> INSERTAR NUEVO MENTOR
        [HttpPost]
        public async Task<ActionResult> Post(Mentor mentor)
        {
            _context.Add(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor);

        }

    }
}
