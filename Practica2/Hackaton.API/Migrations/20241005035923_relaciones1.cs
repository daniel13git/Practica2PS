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
            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HackatonId",
                table: "Proyectos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Participantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HackatonId",
                table: "Mentores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HackatonId",
                table: "Equipos",
                type: "int",
                nullable: true);

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
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hackaton", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_EquipoId",
                table: "Proyectos",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proyectos_HackatonId",
                table: "Proyectos",
                column: "HackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_EquipoId",
                table: "Participantes",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentores_HackatonId",
                table: "Mentores",
                column: "HackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_HackatonId",
                table: "Equipos",
                column: "HackatonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Hackaton_HackatonId",
                table: "Equipos",
                column: "HackatonId",
                principalTable: "Hackaton",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentores_Hackaton_HackatonId",
                table: "Mentores",
                column: "HackatonId",
                principalTable: "Hackaton",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Equipos_EquipoId",
                table: "Participantes",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Equipos_EquipoId",
                table: "Proyectos",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Hackaton_HackatonId",
                table: "Proyectos",
                column: "HackatonId",
                principalTable: "Hackaton",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Hackaton_HackatonId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentores_Hackaton_HackatonId",
                table: "Mentores");

            migrationBuilder.DropForeignKey(
                name: "FK_Participantes_Equipos_EquipoId",
                table: "Participantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_Equipos_EquipoId",
                table: "Proyectos");

            migrationBuilder.DropForeignKey(
                name: "FK_Proyectos_Hackaton_HackatonId",
                table: "Proyectos");

            migrationBuilder.DropTable(
                name: "Hackaton");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_EquipoId",
                table: "Proyectos");

            migrationBuilder.DropIndex(
                name: "IX_Proyectos_HackatonId",
                table: "Proyectos");

            migrationBuilder.DropIndex(
                name: "IX_Participantes_EquipoId",
                table: "Participantes");

            migrationBuilder.DropIndex(
                name: "IX_Mentores_HackatonId",
                table: "Mentores");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_HackatonId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "HackatonId",
                table: "Proyectos");

            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Participantes");

            migrationBuilder.DropColumn(
                name: "HackatonId",
                table: "Mentores");

            migrationBuilder.DropColumn(
                name: "HackatonId",
                table: "Equipos");
        }
    }
}
