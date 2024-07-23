using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sigmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    AverageWeight = table.Column<string>(type: "text", nullable: false),
                    AverageHeight = table.Column<string>(type: "text", nullable: false),
                    Testosterone = table.Column<int>(type: "integer", nullable: false),
                    EvolutionLevel = table.Column<int>(type: "integer", nullable: false),
                    NextStepId = table.Column<int>(type: "integer", nullable: true),
                    PrevStepId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sigmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sigmas_Sigmas_NextStepId",
                        column: x => x.NextStepId,
                        principalTable: "Sigmas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sigmas_Sigmas_PrevStepId",
                        column: x => x.PrevStepId,
                        principalTable: "Sigmas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SigmaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Desription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigmaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SigmaEntitySigmaTypeEntity",
                columns: table => new
                {
                    SigmaTypesId = table.Column<int>(type: "integer", nullable: false),
                    TypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigmaEntitySigmaTypeEntity", x => new { x.SigmaTypesId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_SigmaEntitySigmaTypeEntity_SigmaTypes_TypesId",
                        column: x => x.TypesId,
                        principalTable: "SigmaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SigmaEntitySigmaTypeEntity_Sigmas_SigmaTypesId",
                        column: x => x.SigmaTypesId,
                        principalTable: "Sigmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SigmaEntitySigmaTypeEntity1",
                columns: table => new
                {
                    SigmaWeaknessesId = table.Column<int>(type: "integer", nullable: false),
                    WeaknessesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigmaEntitySigmaTypeEntity1", x => new { x.SigmaWeaknessesId, x.WeaknessesId });
                    table.ForeignKey(
                        name: "FK_SigmaEntitySigmaTypeEntity1_SigmaTypes_WeaknessesId",
                        column: x => x.WeaknessesId,
                        principalTable: "SigmaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SigmaEntitySigmaTypeEntity1_Sigmas_SigmaWeaknessesId",
                        column: x => x.SigmaWeaknessesId,
                        principalTable: "Sigmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SigmaEntitySigmaTypeEntity_TypesId",
                table: "SigmaEntitySigmaTypeEntity",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_SigmaEntitySigmaTypeEntity1_WeaknessesId",
                table: "SigmaEntitySigmaTypeEntity1",
                column: "WeaknessesId");

            migrationBuilder.CreateIndex(
                name: "IX_Sigmas_NextStepId",
                table: "Sigmas",
                column: "NextStepId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sigmas_PrevStepId",
                table: "Sigmas",
                column: "PrevStepId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SigmaEntitySigmaTypeEntity");

            migrationBuilder.DropTable(
                name: "SigmaEntitySigmaTypeEntity1");

            migrationBuilder.DropTable(
                name: "SigmaTypes");

            migrationBuilder.DropTable(
                name: "Sigmas");
        }
    }
}
