using Microsoft.EntityFrameworkCore;
using Plataforma_TechInnovators.Shared.Entities;

namespace Plataforma_TechInnovators.API.Data
{
   

        public class DataContext : DbContext

        {

            public DataContext(DbContextOptions<DataContext> options) : base(options)

            {

            }

            public DbSet<Hackaton> Hackatones { get; set; }
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


