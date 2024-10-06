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

        public DbSet<Hackaton> Hackatons { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Mentor> Mentores { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de la relación Evaluacion - Mentor
            modelBuilder.Entity<Evaluacion>()
                .HasOne(e => e.Mentor)
                .WithMany(m => m.Evaluacion) // Asumiendo que Mentor tiene una colección de Evaluaciones
                .HasForeignKey(e => e.MentorId)
                .OnDelete(DeleteBehavior.NoAction); // Evita el borrado en cascada

            // Configuración de la relación Evaluacion - Proyecto
            modelBuilder.Entity<Evaluacion>()
                .HasOne(e => e.Proyecto)
                .WithMany(p => p.Evaluacion) // Asumiendo que Proyecto tiene una colección de Evaluaciones
                .HasForeignKey(e => e.ProyectoId)
                .OnDelete(DeleteBehavior.NoAction); // Evita el borrado en cascada
        }
    }
}
