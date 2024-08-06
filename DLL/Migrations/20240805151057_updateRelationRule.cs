using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateRelationRule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sigmas_Sigmas_NextStepId",
                table: "Sigmas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sigmas_Sigmas_PrevStepId",
                table: "Sigmas");

            migrationBuilder.DropIndex(
                name: "IX_Sigmas_PrevStepId",
                table: "Sigmas");

            migrationBuilder.CreateIndex(
                name: "IX_Sigmas_PrevStepId",
                table: "Sigmas",
                column: "PrevStepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sigmas_Sigmas_NextStepId",
                table: "Sigmas",
                column: "NextStepId",
                principalTable: "Sigmas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Sigmas_Sigmas_PrevStepId",
                table: "Sigmas",
                column: "PrevStepId",
                principalTable: "Sigmas",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sigmas_Sigmas_NextStepId",
                table: "Sigmas");

            migrationBuilder.DropForeignKey(
                name: "FK_Sigmas_Sigmas_PrevStepId",
                table: "Sigmas");

            migrationBuilder.DropIndex(
                name: "IX_Sigmas_PrevStepId",
                table: "Sigmas");

            migrationBuilder.CreateIndex(
                name: "IX_Sigmas_PrevStepId",
                table: "Sigmas",
                column: "PrevStepId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sigmas_Sigmas_NextStepId",
                table: "Sigmas",
                column: "NextStepId",
                principalTable: "Sigmas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sigmas_Sigmas_PrevStepId",
                table: "Sigmas",
                column: "PrevStepId",
                principalTable: "Sigmas",
                principalColumn: "Id");
        }
    }
}
