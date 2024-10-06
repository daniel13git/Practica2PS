using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.API.Migrations
{
    /// <inheritdoc />
    public partial class relaciones1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hackaton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Organizador = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Premio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hackaton", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CantidadMiembros = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Experiencia = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    HackatonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Hackaton_HackatonId",
                        column: x => x.HackatonId,
                        principalTable: "Hackaton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mentores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AreaExperta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HackatonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mentores_Hackaton_HackatonId",
                        column: x => x.HackatonId,
                        principalTable: "Hackaton",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participantes_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proyectos_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puntaje = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MentorId = table.Column<int>(type: "int", nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluacion_Mentores_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evaluacion_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_HackatonId",
                table: "Equipos",
                column: "HackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacion_MentorId",
                table: "Evaluacion",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacion_ProyectoId",
                table: "Evaluacion",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentores_HackatonId",
                table: "Mentores",
                column: "HackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_EquipoId",
                table: "Participantes",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_EquipoId",
                table: "Proyectos",
                column: "EquipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluacion");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "Mentores");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Hackaton");
        }
    }
}
