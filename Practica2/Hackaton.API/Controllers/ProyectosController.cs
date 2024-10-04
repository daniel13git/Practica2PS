using Hackaton.API.Data;
using Hackaton.SHARED.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Hackaton.API.Controllers
{
    [ApiController]
    [Route("/api/proyectos")]
    public class ProyectosController:ControllerBase
    {
        private readonly DataContext _context;
        public ProyectosController(DataContext context)
        {
            _context = context;
        }

        //GET POR LISTA 
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Proyectos.ToArrayAsync());
        }


        //PUT --> MODIFICAR UN PROYECTO
        [HttpPut]
        public async Task<ActionResult> Put(Proyecto proyecto)
        {
            _context.Update(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto); //Para que muestre que valor modificado

        }

        //DELETE --> BORRAR UN PROYECTO
        [HttpDelete("{id:int}")] //Busque por parametro Id
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Proyectos
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
            var proyecto = await _context.Proyectos.FirstOrDefaultAsync(x => x.Id == id);
            if (proyecto == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(proyecto);
            }
        }


        //POST --> INSERTAR NUEVO PROYECTO
        [HttpPost]
        public async Task<ActionResult> Post(Proyecto proyecto)
        {
            _context.Add(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto);

        }
    }
}
