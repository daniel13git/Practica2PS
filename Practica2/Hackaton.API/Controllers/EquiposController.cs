using Hackaton.API.Data;
using Hackaton.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/equipos")]
    public class EquiposController : ControllerBase
    {
        private readonly DataContext _context;
        public EquiposController(DataContext context)
        {
            _context = context;
        }


        //GET POR LISTA 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Equipos.ToArrayAsync());
        }


        //PUT --> MODIFICAR UN EQUIPO
        [HttpPut]
        public async Task<ActionResult> Put(Equipo equipo)
        {
            _context.Update(equipo);
            await _context.SaveChangesAsync();
            return Ok(equipo); //Para que muestre que valor modificado

        }

        //DELETE --> BORRAR UN EQUIPO
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Equipos
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
            var equipo = await _context.Equipos.FirstOrDefaultAsync(x => x.Id == id);
            if (equipo == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(equipo);
            }
        }


        //POST --> INSERTAR NUEVO PARTICIPANTE
        [HttpPost]
        public async Task<ActionResult> Post(Equipo equipo)
        {
            _context.Add(equipo);
            await _context.SaveChangesAsync();
            return Ok(equipo);

        }


    }
}
