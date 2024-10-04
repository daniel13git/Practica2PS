using Hackaton.API.Data;
using Microsoft.AspNetCore.Mvc;

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
    }
}
