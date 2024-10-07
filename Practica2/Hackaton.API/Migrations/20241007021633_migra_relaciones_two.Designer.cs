﻿// <auto-generated />
using System;
using Hackaton.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hackaton.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241007021633_migra_relaciones_two")]
    partial class migra_relaciones_two
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hackaton.SHARED.Entities.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CantidadMiembros")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<string>("Experiencia")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Organizador")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Premio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Mentor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AreaExperta")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("EventoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Mentores");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Proyecto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("FechaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Evaluacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MentorId")
                        .HasColumnType("int");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int");

                    b.Property<string>("Puntaje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MentorId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("Evaluaciones");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Equipo", b =>
                {
                    b.HasOne("Hackaton.SHARED.Entities.Evento", "Evento")
                        .WithMany("Equipo")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Mentor", b =>
                {
                    b.HasOne("Hackaton.SHARED.Entities.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Participante", b =>
                {
                    b.HasOne("Hackaton.SHARED.Entities.Equipo", "Equipo")
                        .WithMany("Participantes")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Proyecto", b =>
                {
                    b.HasOne("Hackaton.SHARED.Entities.Equipo", "Equipo")
                        .WithMany("Proyecto")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Evaluacion", b =>
                {
                    b.HasOne("Hackaton.SHARED.Entities.Mentor", "Mentor")
                        .WithMany("Evaluacion")
                        .HasForeignKey("MentorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Hackaton.SHARED.Entities.Proyecto", "Proyecto")
                        .WithMany("Evaluacion")
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Mentor");

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Equipo", b =>
                {
                    b.Navigation("Participantes");

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Evento", b =>
                {
                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Mentor", b =>
                {
                    b.Navigation("Evaluacion");
                });

            modelBuilder.Entity("Hackaton.SHARED.Entities.Proyecto", b =>
                {
                    b.Navigation("Evaluacion");
                });
#pragma warning restore 612, 618
        }
    }
}
