using Hackaton.Shared.Entities;
using Hackaton.SHARED.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Mentor> Mentores { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
