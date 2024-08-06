using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSigmaEvoList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SigmaEntityId",
                table: "Sigmas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sigmas_SigmaEntityId",
                table: "Sigmas",
                column: "SigmaEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sigmas_Sigmas_SigmaEntityId",
                table: "Sigmas",
                column: "SigmaEntityId",
                principalTable: "Sigmas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sigmas_Sigmas_SigmaEntityId",
                table: "Sigmas");

            migrationBuilder.DropIndex(
                name: "IX_Sigmas_SigmaEntityId",
                table: "Sigmas");

            migrationBuilder.DropColumn(
                name: "SigmaEntityId",
                table: "Sigmas");
        }
    }
}
