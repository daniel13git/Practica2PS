using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.API.Migrations
{
    /// <inheritdoc />
    public partial class relaciones2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Proyectos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Participantes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Mentores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Premio",
                table: "Hackaton",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Evaluacion_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacion_MentorId",
                table: "Evaluacion",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluacion_ProyectoId",
                table: "Evaluacion",
                column: "ProyectoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Hackaton_HackatonId",
                table: "Equipos",
                column: "HackatonId",
                principalTable: "Hackaton",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentores_Hackaton_HackatonId",
                table: "Mentores",
                column: "HackatonId",
                principalTable: "Hackaton",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participantes_Equipos_EquipoId",
                table: "Participantes",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Equipos_EquipoId",
                table: "Proyectos",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectos_Hackaton_HackatonId",
                table: "Proyectos",
                column: "HackatonId",
                principalTable: "Hackaton",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                name: "Evaluacion");

            migrationBuilder.DropColumn(
                name: "Premio",
                table: "Hackaton");

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Proyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Proyectos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Participantes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Mentores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Equipos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
