using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendasMedicas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Paciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_AspNetUsers_IdentitityUserId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_IdentitityUserId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "IdentitityUserId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "UseId",
                table: "Pacientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentitityUserId",
                table: "Pacientes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UseId",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_IdentitityUserId",
                table: "Pacientes",
                column: "IdentitityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_AspNetUsers_IdentitityUserId",
                table: "Pacientes",
                column: "IdentitityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
