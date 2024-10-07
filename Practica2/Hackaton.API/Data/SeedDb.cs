using Hackaton.Shared.Entities;
using Microsoft.Rest.ClientRuntime.Azure.Authentication.Utilities;

namespace Hackaton.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        //CREAR METODO PARA ASEGURAR CREAR LOS VALORES

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync(); // Asegurar en la BD, que me cree los valores en las tablas
            await CheckEvaluacionesAsync();
        }


        // CREAR UN CHECK PARA CADA TABLA QUE SE NECESITE HACER
        private async Task CheckEvaluacionesAsync()

        {

            if (!_context.Evaluaciones.Any())
            {

                _context.Evaluaciones.Add(new Evaluacion { Puntaje = "1.0" });
                _context.Evaluaciones.Add(new Evaluacion { Puntaje = "2.0" });
                _context.Evaluaciones.Add(new Evaluacion { Puntaje = "3.0" });
                _context.Evaluaciones.Add(new Evaluacion { Puntaje = "4.0" });
                _context.Evaluaciones.Add(new Evaluacion { Puntaje = "5.0" });
            }
            await _context.SaveChangesAsync();
        }

    }
}
