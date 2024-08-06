using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSigmaEvoListRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SigmaEntitySigmaEntity",
                columns: table => new
                {
                    AllEvolutionId = table.Column<int>(type: "integer", nullable: false),
                    SigmaEntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigmaEntitySigmaEntity", x => new { x.AllEvolutionId, x.SigmaEntityId });
                    table.ForeignKey(
                        name: "FK_SigmaEntitySigmaEntity_Sigmas_AllEvolutionId",
                        column: x => x.AllEvolutionId,
                        principalTable: "Sigmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SigmaEntitySigmaEntity_Sigmas_SigmaEntityId",
                        column: x => x.SigmaEntityId,
                        principalTable: "Sigmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SigmaEntitySigmaEntity_SigmaEntityId",
                table: "SigmaEntitySigmaEntity",
                column: "SigmaEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SigmaEntitySigmaEntity");

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
    }
}
