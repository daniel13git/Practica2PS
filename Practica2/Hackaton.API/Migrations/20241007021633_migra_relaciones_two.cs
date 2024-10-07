using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.API.Migrations
{
    /// <inheritdoc />
    public partial class migra_relaciones_two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentores_Eventos_EventoId",
                table: "Mentores");

            migrationBuilder.AlterColumn<int>(
                name: "EventoId",
                table: "Mentores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentores_Eventos_EventoId",
                table: "Mentores",
                column: "EventoId",
                principalTable: "Eventos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentores_Eventos_EventoId",
                table: "Mentores");

            migrationBuilder.AlterColumn<int>(
                name: "EventoId",
                table: "Mentores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentores_Eventos_EventoId",
                table: "Mentores",
                column: "EventoId",
                principalTable: "Eventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
